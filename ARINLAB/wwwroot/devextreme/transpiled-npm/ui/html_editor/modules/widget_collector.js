"use strict";

exports.default = void 0;

var _iterator = require("../../../core/utils/iterator");

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

var WidgetCollector = /*#__PURE__*/function () {
  function WidgetCollector() {
    _classCallCheck(this, WidgetCollector);

    this._collection = [];
  }

  _createClass(WidgetCollector, [{
    key: "clear",
    value: function clear() {
      this._collection = [];
    }
  }, {
    key: "add",
    value: function add(name, instance) {
      this._collection.push({
        name: name,
        instance: instance
      });
    }
  }, {
    key: "getByName",
    value: function getByName(widgetName) {
      var widget = null;
      (0, _iterator.each)(this._collection, function (index, _ref) {
        var name = _ref.name,
            instance = _ref.instance;

        if (name === widgetName) {
          widget = instance;
          return false;
        }
      });
      return widget;
    }
  }, {
    key: "each",
    value: function each(handler) {
      this._collection.forEach(function (_ref2) {
        var name = _ref2.name,
            instance = _ref2.instance;
        return instance && handler(name, instance);
      });
    }
  }]);

  return WidgetCollector;
}();

exports.default = WidgetCollector;
module.exports = exports.default;