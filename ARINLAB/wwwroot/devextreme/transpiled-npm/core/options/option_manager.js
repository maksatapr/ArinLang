"use strict";

exports.OptionManager = void 0;

var _data = require("../utils/data");

var _common = require("../utils/common");

var _comparator = require("../utils/comparator");

var _extend = require("../utils/extend");

var _type = require("../utils/type");

var _utils = require("./utils");

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

var cachedGetters = {};
var cachedSetters = {};

var OptionManager = /*#__PURE__*/function () {
  function OptionManager(options, optionsByReference) {
    _classCallCheck(this, OptionManager);

    this._options = options;
    this._optionsByReference = optionsByReference;
    this._changingCallback;
    this._changedCallback;
    this._namePreparedCallbacks;
  }

  _createClass(OptionManager, [{
    key: "_setByReference",
    value: function _setByReference(options, rulesOptions) {
      (0, _extend.extend)(true, options, rulesOptions);

      for (var fieldName in this._optionsByReference) {
        if (Object.prototype.hasOwnProperty.call(rulesOptions, fieldName)) {
          options[fieldName] = rulesOptions[fieldName];
        }
      }
    }
  }, {
    key: "_setPreparedValue",
    value: function _setPreparedValue(name, value, merge, silent) {
      var previousValue = this.get(this._options, name, false);

      if (!(0, _comparator.equals)(previousValue, value)) {
        var path = name.split(/[.[]/);
        !silent && this._changingCallback(name, previousValue, value);
        cachedSetters[name] = cachedSetters[name] || (0, _data.compileSetter)(name);
        cachedSetters[name](this._options, value, {
          functionsAsIs: true,
          merge: (0, _type.isDefined)(merge) ? merge : !this._optionsByReference[name],
          unwrapObservables: path.length > 1 && !!this._optionsByReference[path[0]]
        });
        !silent && this._changedCallback(name, value, previousValue);
      }
    }
  }, {
    key: "_prepareRelevantNames",
    value: function _prepareRelevantNames(options, name, value, silent) {
      if ((0, _type.isPlainObject)(value)) {
        for (var valueName in value) {
          this._prepareRelevantNames(options, "".concat(name, ".").concat(valueName), value[valueName]);
        }
      }

      this._namePreparedCallbacks(options, name, value, silent);
    }
  }, {
    key: "get",
    value: function get() {
      var options = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : this._options;
      var name = arguments.length > 1 ? arguments[1] : undefined;
      var unwrapObservables = arguments.length > 2 ? arguments[2] : undefined;
      cachedGetters[name] = cachedGetters[name] || (0, _data.compileGetter)(name);
      return cachedGetters[name](options, {
        functionsAsIs: true,
        unwrapObservables: unwrapObservables
      });
    }
  }, {
    key: "set",
    value: function set(options, value, merge, silent) {
      options = (0, _utils.normalizeOptions)(options, value);

      for (var name in options) {
        this._prepareRelevantNames(options, name, options[name], silent);
      }

      for (var _name in options) {
        this._setPreparedValue(_name, options[_name], merge, silent);
      }
    }
  }, {
    key: "onRelevantNamesPrepared",
    value: function onRelevantNamesPrepared(callBack) {
      this._namePreparedCallbacks = callBack;
    }
  }, {
    key: "onChanging",
    value: function onChanging(callBack) {
      this._changingCallback = callBack;
    }
  }, {
    key: "onChanged",
    value: function onChanged(callBack) {
      this._changedCallback = callBack;
    }
  }, {
    key: "dispose",
    value: function dispose() {
      this._changingCallback = _common.noop;
      this._changedCallback = _common.noop;
    }
  }]);

  return OptionManager;
}();

exports.OptionManager = OptionManager;