"use strict";

exports.default = void 0;

var _renderer = _interopRequireDefault(require("../../core/renderer"));

var _extend = require("../../core/utils/extend");

var _window = require("../../core/utils/window");

var _deferred = require("../../core/utils/deferred");

var _message = _interopRequireDefault(require("../../localization/message"));

var _text_box = _interopRequireDefault(require("../text_box"));

var _accordion = _interopRequireDefault(require("../accordion"));

var _scroll_view = _interopRequireDefault(require("../scroll_view"));

var _tooltip = _interopRequireDefault(require("../tooltip"));

var _diagram = require("./diagram.importer");

var _uiDiagram = _interopRequireDefault(require("./ui.diagram.floating_panel"));

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function _typeof(obj) { "@babel/helpers - typeof"; if (typeof Symbol === "function" && typeof Symbol.iterator === "symbol") { _typeof = function _typeof(obj) { return typeof obj; }; } else { _typeof = function _typeof(obj) { return obj && typeof Symbol === "function" && obj.constructor === Symbol && obj !== Symbol.prototype ? "symbol" : typeof obj; }; } return _typeof(obj); }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

function _get(target, property, receiver) { if (typeof Reflect !== "undefined" && Reflect.get) { _get = Reflect.get; } else { _get = function _get(target, property, receiver) { var base = _superPropBase(target, property); if (!base) return; var desc = Object.getOwnPropertyDescriptor(base, property); if (desc.get) { return desc.get.call(receiver); } return desc.value; }; } return _get(target, property, receiver || target); }

function _superPropBase(object, property) { while (!Object.prototype.hasOwnProperty.call(object, property)) { object = _getPrototypeOf(object); if (object === null) break; } return object; }

function _inherits(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function"); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, writable: true, configurable: true } }); if (superClass) _setPrototypeOf(subClass, superClass); }

function _setPrototypeOf(o, p) { _setPrototypeOf = Object.setPrototypeOf || function _setPrototypeOf(o, p) { o.__proto__ = p; return o; }; return _setPrototypeOf(o, p); }

function _createSuper(Derived) { var hasNativeReflectConstruct = _isNativeReflectConstruct(); return function _createSuperInternal() { var Super = _getPrototypeOf(Derived), result; if (hasNativeReflectConstruct) { var NewTarget = _getPrototypeOf(this).constructor; result = Reflect.construct(Super, arguments, NewTarget); } else { result = Super.apply(this, arguments); } return _possibleConstructorReturn(this, result); }; }

function _possibleConstructorReturn(self, call) { if (call && (_typeof(call) === "object" || typeof call === "function")) { return call; } return _assertThisInitialized(self); }

function _assertThisInitialized(self) { if (self === void 0) { throw new ReferenceError("this hasn't been initialised - super() hasn't been called"); } return self; }

function _isNativeReflectConstruct() { if (typeof Reflect === "undefined" || !Reflect.construct) return false; if (Reflect.construct.sham) return false; if (typeof Proxy === "function") return true; try { Date.prototype.toString.call(Reflect.construct(Date, [], function () {})); return true; } catch (e) { return false; } }

function _getPrototypeOf(o) { _getPrototypeOf = Object.setPrototypeOf ? Object.getPrototypeOf : function _getPrototypeOf(o) { return o.__proto__ || Object.getPrototypeOf(o); }; return _getPrototypeOf(o); }

var DIAGRAM_TOOLBOX_MIN_HEIGHT = 130;
var DIAGRAM_TOOLBOX_POPUP_CLASS = 'dx-diagram-toolbox-popup';
var DIAGRAM_TOOLBOX_PANEL_CLASS = 'dx-diagram-toolbox-panel';
var DIAGRAM_TOOLBOX_INPUT_CONTAINER_CLASS = 'dx-diagram-toolbox-input-container';
var DIAGRAM_TOOLBOX_INPUT_CLASS = 'dx-diagram-toolbox-input';
var DIAGRAM_TOOLTIP_DATATOGGLE = 'shape-toolbox-tooltip';
var DIAGRAM_SKIP_GESTURE_CLASS = 'dx-skip-gesture-event';

var DiagramToolbox = /*#__PURE__*/function (_DiagramFloatingPanel) {
  _inherits(DiagramToolbox, _DiagramFloatingPanel);

  var _super = _createSuper(DiagramToolbox);

  function DiagramToolbox() {
    _classCallCheck(this, DiagramToolbox);

    return _super.apply(this, arguments);
  }

  _createClass(DiagramToolbox, [{
    key: "_init",
    value: function _init() {
      _get(_getPrototypeOf(DiagramToolbox.prototype), "_init", this).call(this);

      this._toolboxes = [];
      this._filterText = '';

      this._createOnShapeCategoryRenderedAction();

      this._createOnFilterChangedAction();
    }
  }, {
    key: "_getPopupClass",
    value: function _getPopupClass() {
      return DIAGRAM_TOOLBOX_POPUP_CLASS;
    }
  }, {
    key: "_getPopupHeight",
    value: function _getPopupHeight() {
      return this.isMobileView() ? '100%' : _get(_getPrototypeOf(DiagramToolbox.prototype), "_getPopupHeight", this).call(this);
    }
  }, {
    key: "_getPopupMaxHeight",
    value: function _getPopupMaxHeight() {
      return this.isMobileView() ? '100%' : _get(_getPrototypeOf(DiagramToolbox.prototype), "_getPopupMaxHeight", this).call(this);
    }
  }, {
    key: "_getPopupMinHeight",
    value: function _getPopupMinHeight() {
      return DIAGRAM_TOOLBOX_MIN_HEIGHT;
    }
  }, {
    key: "_getPopupPosition",
    value: function _getPopupPosition() {
      var $parent = this.option('offsetParent');
      var position = {
        my: 'left top',
        at: 'left top',
        of: $parent
      };

      if (!this.isMobileView()) {
        return (0, _extend.extend)(position, {
          offset: this.option('offsetX') + ' ' + this.option('offsetY')
        });
      }

      return position;
    }
  }, {
    key: "_getPopupAnimation",
    value: function _getPopupAnimation() {
      var $parent = this.option('offsetParent');

      if (this.isMobileView()) {
        return {
          hide: this._getPopupSlideAnimationObject({
            direction: 'left',
            from: {
              position: {
                my: 'left top',
                at: 'left top',
                of: $parent
              }
            },
            to: {
              position: {
                my: 'right top',
                at: 'left top',
                of: $parent
              }
            }
          }),
          show: this._getPopupSlideAnimationObject({
            direction: 'right',
            from: {
              position: {
                my: 'right top',
                at: 'left top',
                of: $parent
              }
            },
            to: {
              position: {
                my: 'left top',
                at: 'left top',
                of: $parent
              }
            }
          })
        };
      }

      return _get(_getPrototypeOf(DiagramToolbox.prototype), "_getPopupAnimation", this).call(this);
    }
  }, {
    key: "_getPopupOptions",
    value: function _getPopupOptions() {
      var options = _get(_getPrototypeOf(DiagramToolbox.prototype), "_getPopupOptions", this).call(this);

      if (!this.isMobileView()) {
        return (0, _extend.extend)(options, {
          showTitle: true,
          toolbarItems: [{
            widget: 'dxButton',
            location: 'center',
            options: {
              activeStateEnabled: false,
              focusStateEnabled: false,
              hoverStateEnabled: false,
              icon: 'diagram-toolbox-drag',
              stylingMode: 'outlined',
              type: 'normal'
            }
          }]
        });
      }

      return options;
    }
  }, {
    key: "_renderPopupContent",
    value: function _renderPopupContent($parent) {
      var panelHeight = '100%';

      if (this.option('showSearch')) {
        var $inputContainer = (0, _renderer.default)('<div>').addClass(DIAGRAM_TOOLBOX_INPUT_CONTAINER_CLASS).appendTo($parent);

        this._updateElementWidth($inputContainer);

        this._renderSearchInput($inputContainer);

        if ((0, _window.hasWindow)()) {
          panelHeight = 'calc(100% - ' + this._searchInput.$element().height() + 'px)';
        }
      }

      var $panel = (0, _renderer.default)('<div>').addClass(DIAGRAM_TOOLBOX_PANEL_CLASS).appendTo($parent).height(panelHeight);

      this._updateElementWidth($panel);

      this._renderScrollView($panel);
    }
  }, {
    key: "_updateElementWidth",
    value: function _updateElementWidth($element) {
      if (this.option('toolboxWidth') !== undefined) {
        $element.css('width', this.option('toolboxWidth'));
      }
    }
  }, {
    key: "updateMaxHeight",
    value: function updateMaxHeight() {
      if (this.isMobileView()) return;
      var maxHeight = 6;

      if (this._popup) {
        var $title = this._getPopupTitle();

        maxHeight += $title.outerHeight();
      }

      if (this._accordion) {
        maxHeight += this._accordion.$element().outerHeight();
      }

      if (this._searchInput) {
        maxHeight += this._searchInput.$element().outerHeight();
      }

      this.option('maxHeight', maxHeight);
    }
  }, {
    key: "_renderSearchInput",
    value: function _renderSearchInput($parent) {
      var _this = this;

      var $input = (0, _renderer.default)('<div>').addClass(DIAGRAM_TOOLBOX_INPUT_CLASS).appendTo($parent);
      this._searchInput = this._createComponent($input, _text_box.default, {
        stylingMode: 'outlined',
        placeholder: _message.default.format('dxDiagram-uiSearch'),
        onValueChanged: function onValueChanged(data) {
          _this._onInputChanged(data.value);
        },
        valueChangeEvent: 'keyup',
        buttons: [{
          name: 'search',
          location: 'after',
          options: {
            activeStateEnabled: false,
            focusStateEnabled: false,
            hoverStateEnabled: false,
            icon: 'search',
            stylingMode: 'outlined',
            type: 'normal',
            onClick: function onClick() {
              _this._searchInput.focus();
            }
          }
        }]
      });
    }
  }, {
    key: "_renderScrollView",
    value: function _renderScrollView($parent) {
      var $scrollViewWrapper = (0, _renderer.default)('<div>').appendTo($parent);
      this._scrollView = this._createComponent($scrollViewWrapper, _scroll_view.default);
      var $accordion = (0, _renderer.default)('<div>').appendTo(this._scrollView.content());

      this._updateElementWidth($accordion);

      this._renderAccordion($accordion);
    }
  }, {
    key: "_getAccordionDataSource",
    value: function _getAccordionDataSource() {
      var _this2 = this;

      var result = [];
      var toolboxGroups = this.option('toolboxGroups');

      for (var i = 0; i < toolboxGroups.length; i++) {
        var category = toolboxGroups[i].category;
        var title = toolboxGroups[i].title;
        var groupObj = {
          category: category,
          title: title || category,
          expanded: toolboxGroups[i].expanded,
          displayMode: toolboxGroups[i].displayMode,
          shapes: toolboxGroups[i].shapes,
          onTemplate: function onTemplate(widget, $element, data) {
            var $toolboxElement = (0, _renderer.default)($element);

            _this2._onShapeCategoryRenderedAction({
              category: data.category,
              displayMode: data.displayMode,
              dataToggle: DIAGRAM_TOOLTIP_DATATOGGLE,
              shapes: data.shapes,
              $element: $toolboxElement
            });

            _this2._toolboxes.push($toolboxElement);

            if (_this2._filterText !== '') {
              _this2._onFilterChangedAction({
                text: _this2._filterText,
                filteringToolboxes: _this2._toolboxes.length - 1
              });
            }

            _this2._createTooltips($toolboxElement.find('[data-toggle="' + DIAGRAM_TOOLTIP_DATATOGGLE + '"]'));
          }
        };
        result.push(groupObj);
      }

      return result;
    }
  }, {
    key: "_createTooltips",
    value: function _createTooltips(targets) {
      var _this3 = this;

      var _getDiagram = (0, _diagram.getDiagram)(),
          Browser = _getDiagram.Browser;

      if (Browser.TouchUI) return;
      var $container = this.$element();
      targets.each(function (index, element) {
        var $target = (0, _renderer.default)(element);
        var title = $target.attr('title');

        if (title) {
          var $tooltip = (0, _renderer.default)('<div>').html(title).appendTo($container);

          _this3._createComponent($tooltip, _tooltip.default, {
            target: $target.get(0),
            showEvent: 'mouseenter',
            hideEvent: 'mouseleave',
            position: 'top',
            animation: {
              show: {
                type: 'fade',
                from: 0,
                to: 1,
                delay: 500
              },
              hide: {
                type: 'fade',
                from: 1,
                to: 0,
                delay: 100
              }
            }
          });
        }
      });
    }
  }, {
    key: "_renderAccordion",
    value: function _renderAccordion($container) {
      var _this4 = this;

      var data = this._getAccordionDataSource();

      this._accordion = this._createComponent($container, _accordion.default, {
        multiple: true,
        animationDuration: 0,
        activeStateEnabled: false,
        focusStateEnabled: false,
        hoverStateEnabled: false,
        collapsible: true,
        displayExpr: 'title',
        dataSource: data,
        disabled: this.option('disabled'),
        itemTemplate: function itemTemplate(data, index, $element) {
          data.onTemplate(_this4, $element, data);
        },
        onSelectionChanged: function onSelectionChanged(e) {
          _this4._updateScrollAnimateSubscription(e.component);
        },
        onContentReady: function onContentReady(e) {
          for (var i = 0; i < data.length; i++) {
            if (data[i].expanded === false) {
              e.component.collapseItem(i);
            } else if (data[i].expanded === true) {
              e.component.expandItem(i);
            }
          }

          _this4._updateScrollAnimateSubscription(e.component);
        }
      });
    }
  }, {
    key: "_updateScrollAnimateSubscription",
    value: function _updateScrollAnimateSubscription(component) {
      var _this5 = this;

      component._deferredAnimate = new _deferred.Deferred();

      component._deferredAnimate.done(function () {
        _this5.updateMaxHeight();

        _this5._scrollView.update();

        _this5._updateScrollAnimateSubscription(component);
      });
    }
  }, {
    key: "_raiseToolboxDragStart",
    value: function _raiseToolboxDragStart() {
      this._scrollView.$element().addClass(DIAGRAM_SKIP_GESTURE_CLASS);
    }
  }, {
    key: "_raiseToolboxDragEnd",
    value: function _raiseToolboxDragEnd() {
      this._scrollView.$element().removeClass(DIAGRAM_SKIP_GESTURE_CLASS);
    }
  }, {
    key: "_onInputChanged",
    value: function _onInputChanged(text) {
      var _this6 = this;

      this._filterText = text;

      this._onFilterChangedAction({
        text: this._filterText,
        filteringToolboxes: this._toolboxes.map(function ($element, index) {
          return index;
        })
      });

      this._toolboxes.forEach(function ($element) {
        var $tooltipContainer = (0, _renderer.default)($element);

        _this6._createTooltips($tooltipContainer.find('[data-toggle="' + DIAGRAM_TOOLTIP_DATATOGGLE + '"]'));
      });

      this.updateMaxHeight();

      this._scrollView.update();
    }
  }, {
    key: "_createOnShapeCategoryRenderedAction",
    value: function _createOnShapeCategoryRenderedAction() {
      this._onShapeCategoryRenderedAction = this._createActionByOption('onShapeCategoryRendered');
    }
  }, {
    key: "_createOnFilterChangedAction",
    value: function _createOnFilterChangedAction() {
      this._onFilterChangedAction = this._createActionByOption('onFilterChanged');
    }
  }, {
    key: "_optionChanged",
    value: function _optionChanged(args) {
      switch (args.name) {
        case 'onShapeCategoryRendered':
          this._createOnShapeCategoryRenderedAction();

          break;

        case 'onFilterChanged':
          this._createOnFilterChangedAction();

          break;

        case 'showSearch':
        case 'toolboxWidth':
          this._invalidate();

          break;

        case 'toolboxGroups':
          this._accordion.option('dataSource', this._getAccordionDataSource());

          break;

        default:
          _get(_getPrototypeOf(DiagramToolbox.prototype), "_optionChanged", this).call(this, args);

      }
    }
  }]);

  return DiagramToolbox;
}(_uiDiagram.default);

var _default = DiagramToolbox;
exports.default = _default;
module.exports = exports.default;