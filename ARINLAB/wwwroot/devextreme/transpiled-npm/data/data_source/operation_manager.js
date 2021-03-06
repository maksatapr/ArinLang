"use strict";

exports.default = void 0;

var _utils = require("./utils");

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

var OperationManager = /*#__PURE__*/function () {
  function OperationManager() {
    _classCallCheck(this, OperationManager);

    this._counter = -1;
    this._deferreds = {};
  }

  _createClass(OperationManager, [{
    key: "add",
    value: function add(deferred) {
      this._counter++;
      this._deferreds[this._counter] = deferred;
      return this._counter;
    }
  }, {
    key: "remove",
    value: function remove(operationId) {
      return delete this._deferreds[operationId];
    }
  }, {
    key: "cancel",
    value: function cancel(operationId) {
      if (operationId in this._deferreds) {
        this._deferreds[operationId].reject(_utils.CANCELED_TOKEN);

        return true;
      }

      return false;
    }
  }, {
    key: "cancelAll",
    value: function cancelAll() {
      while (this._counter > -1) {
        this.cancel(this._counter);
        this._counter--;
      }
    }
  }]);

  return OperationManager;
}();

exports.default = OperationManager;
module.exports = exports.default;