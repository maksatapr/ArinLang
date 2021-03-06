"use strict";

exports.AppointmentSettingsGeneratorVirtualStrategy = exports.AppointmentSettingsGeneratorBaseStrategy = exports.AppointmentSettingsGenerator = void 0;

var _date = _interopRequireDefault(require("../../core/utils/date"));

var _type = require("../../core/utils/type");

var _extend = require("../../core/utils/extend");

var _recurrence = require("./recurrence");

var _utilsTimeZone = _interopRequireDefault(require("./utils.timeZone.js"));

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function _typeof(obj) { "@babel/helpers - typeof"; if (typeof Symbol === "function" && typeof Symbol.iterator === "symbol") { _typeof = function _typeof(obj) { return typeof obj; }; } else { _typeof = function _typeof(obj) { return obj && typeof Symbol === "function" && obj.constructor === Symbol && obj !== Symbol.prototype ? "symbol" : typeof obj; }; } return _typeof(obj); }

function _toConsumableArray(arr) { return _arrayWithoutHoles(arr) || _iterableToArray(arr) || _unsupportedIterableToArray(arr) || _nonIterableSpread(); }

function _nonIterableSpread() { throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method."); }

function _iterableToArray(iter) { if (typeof Symbol !== "undefined" && Symbol.iterator in Object(iter)) return Array.from(iter); }

function _arrayWithoutHoles(arr) { if (Array.isArray(arr)) return _arrayLikeToArray(arr); }

function _get(target, property, receiver) { if (typeof Reflect !== "undefined" && Reflect.get) { _get = Reflect.get; } else { _get = function _get(target, property, receiver) { var base = _superPropBase(target, property); if (!base) return; var desc = Object.getOwnPropertyDescriptor(base, property); if (desc.get) { return desc.get.call(receiver); } return desc.value; }; } return _get(target, property, receiver || target); }

function _superPropBase(object, property) { while (!Object.prototype.hasOwnProperty.call(object, property)) { object = _getPrototypeOf(object); if (object === null) break; } return object; }

function _inherits(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function"); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, writable: true, configurable: true } }); if (superClass) _setPrototypeOf(subClass, superClass); }

function _setPrototypeOf(o, p) { _setPrototypeOf = Object.setPrototypeOf || function _setPrototypeOf(o, p) { o.__proto__ = p; return o; }; return _setPrototypeOf(o, p); }

function _createSuper(Derived) { var hasNativeReflectConstruct = _isNativeReflectConstruct(); return function _createSuperInternal() { var Super = _getPrototypeOf(Derived), result; if (hasNativeReflectConstruct) { var NewTarget = _getPrototypeOf(this).constructor; result = Reflect.construct(Super, arguments, NewTarget); } else { result = Super.apply(this, arguments); } return _possibleConstructorReturn(this, result); }; }

function _possibleConstructorReturn(self, call) { if (call && (_typeof(call) === "object" || typeof call === "function")) { return call; } return _assertThisInitialized(self); }

function _assertThisInitialized(self) { if (self === void 0) { throw new ReferenceError("this hasn't been initialised - super() hasn't been called"); } return self; }

function _isNativeReflectConstruct() { if (typeof Reflect === "undefined" || !Reflect.construct) return false; if (Reflect.construct.sham) return false; if (typeof Proxy === "function") return true; try { Date.prototype.toString.call(Reflect.construct(Date, [], function () {})); return true; } catch (e) { return false; } }

function _getPrototypeOf(o) { _getPrototypeOf = Object.setPrototypeOf ? Object.getPrototypeOf : function _getPrototypeOf(o) { return o.__proto__ || Object.getPrototypeOf(o); }; return _getPrototypeOf(o); }

function _slicedToArray(arr, i) { return _arrayWithHoles(arr) || _iterableToArrayLimit(arr, i) || _unsupportedIterableToArray(arr, i) || _nonIterableRest(); }

function _nonIterableRest() { throw new TypeError("Invalid attempt to destructure non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method."); }

function _unsupportedIterableToArray(o, minLen) { if (!o) return; if (typeof o === "string") return _arrayLikeToArray(o, minLen); var n = Object.prototype.toString.call(o).slice(8, -1); if (n === "Object" && o.constructor) n = o.constructor.name; if (n === "Map" || n === "Set") return Array.from(o); if (n === "Arguments" || /^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(n)) return _arrayLikeToArray(o, minLen); }

function _arrayLikeToArray(arr, len) { if (len == null || len > arr.length) len = arr.length; for (var i = 0, arr2 = new Array(len); i < len; i++) { arr2[i] = arr[i]; } return arr2; }

function _iterableToArrayLimit(arr, i) { if (typeof Symbol === "undefined" || !(Symbol.iterator in Object(arr))) return; var _arr = []; var _n = true; var _d = false; var _e = undefined; try { for (var _i = arr[Symbol.iterator](), _s; !(_n = (_s = _i.next()).done); _n = true) { _arr.push(_s.value); if (i && _arr.length === i) break; } } catch (err) { _d = true; _e = err; } finally { try { if (!_n && _i["return"] != null) _i["return"](); } finally { if (_d) throw _e; } } return _arr; }

function _arrayWithHoles(arr) { if (Array.isArray(arr)) return arr; }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

var toMs = _date.default.dateToMilliseconds;

var AppointmentSettingsGenerator = /*#__PURE__*/function () {
  function AppointmentSettingsGenerator(scheduler) {
    _classCallCheck(this, AppointmentSettingsGenerator);

    this.scheduler = scheduler;
    this.settingsStrategy = this.scheduler.isVirtualScrolling() ? new AppointmentSettingsGeneratorVirtualStrategy(this.scheduler) : new AppointmentSettingsGeneratorBaseStrategy(this.scheduler);
  }

  _createClass(AppointmentSettingsGenerator, [{
    key: "create",
    value: function create(rawAppointment) {
      return this.settingsStrategy.create(rawAppointment);
    }
  }]);

  return AppointmentSettingsGenerator;
}();

exports.AppointmentSettingsGenerator = AppointmentSettingsGenerator;

var AppointmentSettingsGeneratorBaseStrategy = /*#__PURE__*/function () {
  function AppointmentSettingsGeneratorBaseStrategy(scheduler) {
    _classCallCheck(this, AppointmentSettingsGeneratorBaseStrategy);

    this.scheduler = scheduler;
  }

  _createClass(AppointmentSettingsGeneratorBaseStrategy, [{
    key: "create",
    value: function create(rawAppointment) {
      var scheduler = this.scheduler;
      var appointment = scheduler.createAppointmentAdapter(rawAppointment);

      var itemResources = scheduler._resourcesManager.getResourcesFromItem(rawAppointment);

      var appointmentList = this._createAppointments(appointment, itemResources);

      if (this._canProcessNotNativeTimezoneDates(appointmentList, appointment)) {
        appointmentList = this._getProcessedNotNativeTimezoneDates(appointmentList, appointment);
      }

      var gridAppointmentList = this._createGridAppointmentList(appointmentList);

      gridAppointmentList = this._cropAppointmentsByStartDayHour(gridAppointmentList, rawAppointment);
      gridAppointmentList = this._getProcessedLongAppointmentsIfRequired(gridAppointmentList, appointment);

      var allDay = this.scheduler.appointmentTakesAllDay(rawAppointment) && this.scheduler._workSpace.supportAllDayRow();

      return this._createAppointmentInfos(gridAppointmentList, itemResources, allDay);
    }
  }, {
    key: "_createAppointments",
    value: function _createAppointments(appointment, resources) {
      var appointmentList = this._createRecurrenceAppointments(appointment, resources);

      if (appointmentList.length === 0) {
        appointmentList.push({
          startDate: appointment.startDate,
          endDate: appointment.endDate
        });
      }

      return appointmentList;
    }
  }, {
    key: "_canProcessNotNativeTimezoneDates",
    value: function _canProcessNotNativeTimezoneDates(appointmentList, appointment) {
      var timeZoneName = this.scheduler.option('timeZone');
      var isEqualLocalTimeZone = _utilsTimeZone.default.isEqualLocalTimeZone,
          hasDSTInLocalTimeZone = _utilsTimeZone.default.hasDSTInLocalTimeZone;
      var isRecurrence = appointmentList.length > 1;
      var isTimeZoneSet = !(0, _type.isEmptyObject)(timeZoneName);
      var isAppointmentTimeZoneSet = !(0, _type.isEmptyObject)(appointment.startDateTimeZone);

      if (!isRecurrence) {
        return false;
      }

      if (!isTimeZoneSet && hasDSTInLocalTimeZone()) {
        return false;
      }

      return isTimeZoneSet && !isAppointmentTimeZoneSet && !isEqualLocalTimeZone(timeZoneName);
    }
  }, {
    key: "_getProcessedNotNativeDateIfCrossDST",
    value: function _getProcessedNotNativeDateIfCrossDST(date, dateRangeOffset) {
      var newDate = new Date(date);
      var newDateMinusOneHour = new Date(newDate);
      newDateMinusOneHour.setHours(newDateMinusOneHour.getHours() - 1);
      var newDateOffset = this.timeZoneCalculator.getOffsets(newDate).common;
      var newDateMinusOneHourOffset = this.timeZoneCalculator.getOffsets(newDateMinusOneHour).common;

      if (newDateOffset !== newDateMinusOneHourOffset) {
        return 0;
      }

      return dateRangeOffset;
    }
  }, {
    key: "_getProcessedNotNativeTimezoneDates",
    value: function _getProcessedNotNativeTimezoneDates(appointmentList, appointment) {
      var _this = this;

      var startDateRange = appointmentList[0].startDate;
      var endDateRange = appointmentList[appointmentList.length - 1].endDate;
      var startDateRangeOffset = this.timeZoneCalculator.getOffsets(startDateRange).common;
      var endDateRangeOffset = this.timeZoneCalculator.getOffsets(endDateRange).common;
      var isChangeOffsetInRange = startDateRangeOffset !== endDateRangeOffset;

      if (isChangeOffsetInRange) {
        return appointmentList.map(function (a) {
          var diffStartDateOffset = _this.timeZoneCalculator.getOffsets(appointment.startDate).common - _this.timeZoneCalculator.getOffsets(a.startDate).common;

          var diffEndDateOffset = _this.timeZoneCalculator.getOffsets(appointment.endDate).common - _this.timeZoneCalculator.getOffsets(a.endDate).common;

          if (diffStartDateOffset < 0) {
            // summer time
            diffStartDateOffset = _this._getProcessedNotNativeDateIfCrossDST(a.startDate, diffStartDateOffset);
            diffEndDateOffset = _this._getProcessedNotNativeDateIfCrossDST(a.endDate, diffEndDateOffset);
          }

          var newStartDate = new Date(a.startDate.getTime() + diffStartDateOffset * toMs('hour'));
          var newEndDate = new Date(a.endDate.getTime() + diffEndDateOffset * toMs('hour'));

          var testNewStartDate = _this.timeZoneCalculator.createDate(newStartDate, {
            path: 'toGrid'
          });

          var testNewEndDate = _this.timeZoneCalculator.createDate(newEndDate, {
            path: 'toGrid'
          });

          if (appointment.duration > testNewEndDate.getTime() - testNewStartDate.getTime()) {
            newEndDate = new Date(newStartDate.getTime() + appointment.duration);
          }

          return {
            startDate: newStartDate,
            endDate: newEndDate
          };
        });
      }

      return appointmentList;
    }
  }, {
    key: "_getProcessedLongAppointmentsIfRequired",
    value: function _getProcessedLongAppointmentsIfRequired(gridAppointmentList, appointment) {
      var _this2 = this;

      var rawAppointment = appointment.source();
      var allDay = this.scheduler.appointmentTakesAllDay(rawAppointment);

      var dateRange = this.scheduler._workSpace.getDateRange();

      var renderingStrategy = this.scheduler.getLayoutManager().getRenderingStrategyInstance();

      if (renderingStrategy.needSeparateAppointment(allDay)) {
        var longStartDateParts = [];
        var resultDates = [];
        gridAppointmentList.forEach(function (gridAppointment) {
          var maxDate = new Date(dateRange[1]);
          var endDateOfPart = renderingStrategy.normalizeEndDateByViewEnd(rawAppointment, gridAppointment.endDate);
          longStartDateParts = _date.default.getDatesOfInterval(gridAppointment.startDate, endDateOfPart, {
            milliseconds: _this2.scheduler.getWorkSpace().getIntervalDuration(allDay)
          });
          var list = longStartDateParts.filter(function (startDatePart) {
            return new Date(startDatePart) < maxDate;
          }).map(function (date) {
            return {
              startDate: date,
              endDate: new Date(new Date(date).setMilliseconds(appointment.duration)),
              source: gridAppointment.source
            };
          });
          resultDates = resultDates.concat(list);
        });
        gridAppointmentList = resultDates;
      }

      return gridAppointmentList;
    }
  }, {
    key: "_createGridAppointmentList",
    value: function _createGridAppointmentList(appointmentList) {
      var _this3 = this;

      return appointmentList.map(function (source) {
        var startDate = _this3.timeZoneCalculator.createDate(source.startDate, {
          path: 'toGrid'
        });

        var endDate = _this3.timeZoneCalculator.createDate(source.endDate, {
          path: 'toGrid'
        });

        return {
          startDate: startDate,
          endDate: endDate,
          source: source // TODO

        };
      });
    }
  }, {
    key: "_createExtremeRecurrenceDates",
    value: function _createExtremeRecurrenceDates(rawAppointment, groupIndex) {
      var dateRange = this._getGroupDateRange(groupIndex);

      var startViewDate = this.scheduler.appointmentTakesAllDay(rawAppointment) ? _date.default.trimTime(dateRange[0]) : dateRange[0];
      var commonTimeZone = this.scheduler.option('timeZone');
      var minRecurrenceDate = commonTimeZone ? this.timeZoneCalculator.createDate(startViewDate, {
        path: 'fromGrid'
      }) : startViewDate;
      var maxRecurrenceDate = commonTimeZone ? this.timeZoneCalculator.createDate(dateRange[1], {
        path: 'fromGrid'
      }) : dateRange[1];
      return [minRecurrenceDate, maxRecurrenceDate];
    }
  }, {
    key: "_getGroupDateRange",
    value: function _getGroupDateRange(groupIndex) {
      return this.scheduler._workSpace.getDateRange();
    }
  }, {
    key: "_createRecurrenceOptions",
    value: function _createRecurrenceOptions(appointment, groupIndex) {
      var _this$_createExtremeR = this._createExtremeRecurrenceDates(appointment.source(), groupIndex),
          _this$_createExtremeR2 = _slicedToArray(_this$_createExtremeR, 2),
          minRecurrenceDate = _this$_createExtremeR2[0],
          maxRecurrenceDate = _this$_createExtremeR2[1];

      return {
        rule: appointment.recurrenceRule,
        exception: appointment.recurrenceException,
        min: minRecurrenceDate,
        max: maxRecurrenceDate,
        firstDayOfWeek: this.scheduler.getFirstDayOfWeek(),
        start: appointment.startDate,
        end: appointment.endDate
      };
    }
  }, {
    key: "_createRecurrenceAppointments",
    value: function _createRecurrenceAppointments(appointment, resources) {
      var duration = appointment.duration;

      var option = this._createRecurrenceOptions(appointment);

      var generatedStartDates = (0, _recurrence.getRecurrenceProcessor)().generateDates(option);
      return generatedStartDates.map(function (date) {
        var utcDate = _utilsTimeZone.default.createUTCDateWithLocalOffset(date);

        utcDate.setTime(utcDate.getTime() + duration);

        var endDate = _utilsTimeZone.default.createDateFromUTCWithLocalOffset(utcDate);

        return {
          startDate: new Date(date),
          endDate: endDate
        };
      });
    }
  }, {
    key: "_getGroupIndices",
    value: function _getGroupIndices(resources) {
      var workspace = this.scheduler._workSpace;
      return workspace._getGroupIndexes(resources);
    }
  }, {
    key: "_cropAppointmentsByStartDayHour",
    value: function _cropAppointmentsByStartDayHour(appointments, rawAppointment) {
      var _this4 = this;

      return appointments.map(function (appointment) {
        var startDate = new Date(appointment.startDate);

        var firstViewDate = _this4._getAppointmentFirstViewDate(appointment, startDate);

        var startDayHour = _this4._getViewStartDayHour(firstViewDate);

        appointment.startDate = _this4._getAppointmentResultDate({
          appointment: appointment,
          rawAppointment: rawAppointment,
          startDate: startDate,
          startDayHour: startDayHour,
          firstViewDate: firstViewDate
        });
        return appointment;
      });
    }
  }, {
    key: "_getAppointmentFirstViewDate",
    value: function _getAppointmentFirstViewDate() {
      return this.scheduler.getStartViewDate();
    }
  }, {
    key: "_getViewStartDayHour",
    value: function _getViewStartDayHour() {
      return this.scheduler._getCurrentViewOption('startDayHour');
    }
  }, {
    key: "_getAppointmentResultDate",
    value: function _getAppointmentResultDate(options) {
      var appointment = options.appointment,
          rawAppointment = options.rawAppointment,
          startDayHour = options.startDayHour,
          firstViewDate = options.firstViewDate;
      var startDate = options.startDate;
      var resultDate = new Date(appointment.startDate);

      if (this.scheduler.appointmentTakesAllDay(rawAppointment)) {
        resultDate = _date.default.normalizeDate(startDate, firstViewDate);
      } else {
        if (startDate < firstViewDate) {
          startDate = firstViewDate;
        }

        resultDate = _date.default.normalizeDate(appointment.startDate, startDate);
      }

      return _date.default.roundDateByStartDayHour(resultDate, startDayHour);
    }
  }, {
    key: "_createAppointmentInfos",
    value: function _createAppointmentInfos(gridAppointments, appointmentResources, allDay) {
      var _this5 = this;

      var result = [];

      var _loop = function _loop(i) {
        var coordinates = _this5.scheduler._workSpace.getCoordinatesByDateInGroup(gridAppointments[i].startDate, appointmentResources, allDay);

        coordinates.forEach(function (coordinate) {
          (0, _extend.extend)(coordinate, {
            info: {
              appointment: gridAppointments[i],
              sourceAppointment: gridAppointments[i].source
            }
          });
        });
        result = result.concat(coordinates);
      };

      for (var i = 0; i < gridAppointments.length; i++) {
        _loop(i);
      }

      return result;
    }
  }, {
    key: "timeZoneCalculator",
    get: function get() {
      return this.scheduler.timeZoneCalculator;
    }
  }]);

  return AppointmentSettingsGeneratorBaseStrategy;
}();

exports.AppointmentSettingsGeneratorBaseStrategy = AppointmentSettingsGeneratorBaseStrategy;

var AppointmentSettingsGeneratorVirtualStrategy = /*#__PURE__*/function (_AppointmentSettingsG) {
  _inherits(AppointmentSettingsGeneratorVirtualStrategy, _AppointmentSettingsG);

  var _super = _createSuper(AppointmentSettingsGeneratorVirtualStrategy);

  function AppointmentSettingsGeneratorVirtualStrategy() {
    _classCallCheck(this, AppointmentSettingsGeneratorVirtualStrategy);

    return _super.apply(this, arguments);
  }

  _createClass(AppointmentSettingsGeneratorVirtualStrategy, [{
    key: "_createRecurrenceAppointments",
    value: function _createRecurrenceAppointments(appointment, resources) {
      var _this6 = this;

      var duration = appointment.duration;
      var result = [];
      var workspace = this.scheduler._workSpace;
      var groupIndices = workspace._getGroupCount() ? this._getGroupIndices(resources) : [0];
      groupIndices.forEach(function (groupIndex) {
        var option = _this6._createRecurrenceOptions(appointment, groupIndex);

        var generatedStartDates = (0, _recurrence.getRecurrenceProcessor)().generateDates(option);
        var dates = generatedStartDates.map(function (date) {
          var utcDate = _utilsTimeZone.default.createUTCDateWithLocalOffset(date);

          utcDate.setTime(utcDate.getTime() + duration);

          var endDate = _utilsTimeZone.default.createDateFromUTCWithLocalOffset(utcDate);

          return {
            startDate: new Date(date),
            endDate: endDate
          };
        });
        result.push.apply(result, _toConsumableArray(dates));
      });
      return result;
    }
  }, {
    key: "_getViewStartDayHour",
    value: function _getViewStartDayHour(firstViewDate) {
      return firstViewDate.getHours();
    }
  }, {
    key: "_getAppointmentFirstViewDate",
    value: function _getAppointmentFirstViewDate(appointment, startDate) {
      var workspace = this.scheduler.getWorkSpace();
      var groupIndex = appointment.source.groupIndex;
      var viewDataProvider = workspace.viewDataProvider;
      var firstViewDate = viewDataProvider.getGroupCellStartDate(groupIndex, startDate);

      if (!firstViewDate) {
        firstViewDate = viewDataProvider.getGroupStartDate(groupIndex);
      }

      return firstViewDate;
    }
  }, {
    key: "_getGroupDateRange",
    value: function _getGroupDateRange(groupIndex) {
      var _this$scheduler$getWo = this.scheduler.getWorkSpace(),
          viewDataProvider = _this$scheduler$getWo.viewDataProvider;

      var startDate = viewDataProvider.getGroupStartDate(groupIndex);
      var groupEndDate = viewDataProvider.getGroupEndDate(groupIndex);
      var endDate = new Date(groupEndDate.getTime() - 1);
      return [startDate, endDate];
    }
  }, {
    key: "_updateGroupIndices",
    value: function _updateGroupIndices(appointments, itemResources) {
      var workspace = this.scheduler.getWorkSpace();
      var groupIndices = workspace._isVerticalGroupedWorkSpace() ? workspace._getGroupIndexes(itemResources) : [0];
      groupIndices.forEach(function (groupIndex) {
        appointments.forEach(function (appointment) {
          return appointment.groupIndex = groupIndex;
        });
      });
    }
  }, {
    key: "_getGroupIndices",
    value: function _getGroupIndices(resources) {
      var groupIndices = _get(_getPrototypeOf(AppointmentSettingsGeneratorVirtualStrategy.prototype), "_getGroupIndices", this).call(this, resources);

      var _this$scheduler$getWo2 = this.scheduler.getWorkSpace(),
          viewDataProvider = _this$scheduler$getWo2.viewDataProvider;

      var viewDataGroupIndices = viewDataProvider.getGroupIndices();
      var result = groupIndices.filter(function (groupIndex) {
        return viewDataGroupIndices.indexOf(groupIndex) !== -1;
      });
      return result;
    }
  }, {
    key: "_createAppointments",
    value: function _createAppointments(appointment, resources) {
      var result = _get(_getPrototypeOf(AppointmentSettingsGeneratorVirtualStrategy.prototype), "_createAppointments", this).call(this, appointment, resources);

      this._updateGroupIndices(result, resources);

      return result;
    }
  }]);

  return AppointmentSettingsGeneratorVirtualStrategy;
}(AppointmentSettingsGeneratorBaseStrategy);

exports.AppointmentSettingsGeneratorVirtualStrategy = AppointmentSettingsGeneratorVirtualStrategy;