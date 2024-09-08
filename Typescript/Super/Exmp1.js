"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
exports.car = exports.C2 = exports.colors = exports.college = exports.C = exports.B = exports.A = void 0;
var A = /** @class */ (function () {
    function A(name) {
        this.name = name;
    }
    A.prototype.show = function () {
        console.log("OUR NAME IS  : " + this.name);
    };
    return A;
}());
exports.A = A;
var B = /** @class */ (function (_super) {
    __extends(B, _super);
    function B(name) {
        return _super.call(this, name) || this;
    }
    return B;
}(A));
exports.B = B;
var C = /** @class */ (function (_super) {
    __extends(C, _super);
    function C(firstName, lastName) {
        var _this = _super.call(this, firstName) || this;
        _this.lastName = lastName;
        return _this;
    }
    C.prototype.show = function () {
        console.log("OUR FULL NAME IS: " + this.name + " " + this.lastName);
    };
    return C;
}(B));
exports.C = C;
var college = /** @class */ (function () {
    function college() {
        this.studentsList = [];
    }
    college.prototype.show = function (DATA) {
        this.studentsList.push(DATA);
        for (var _i = 0, _a = this.studentsList; _i < _a.length; _i++) {
            var res = _a[_i];
            console.log("ID : " + res.ID);
            console.log("NAME : " + res.NAME);
            console.log("CLASS NAME : " + res.CLASS_NAME);
            console.log("AGE : " + res.AGE);
        }
    };
    return college;
}());
exports.college = college;
var colors;
(function (colors) {
    colors["red"] = "RED";
    colors["green"] = "GREEN";
    colors["blue"] = "BLUE";
    colors["orange"] = "ORANGE";
})(colors || (exports.colors = colors = {}));
var C1 = /** @class */ (function () {
    function C1(name) {
        this.name = name;
        console.log("OUR NAME IS " + name);
    }
    return C1;
}());
var C2 = /** @class */ (function (_super) {
    __extends(C2, _super);
    function C2(name, color) {
        var _this = _super.call(this, name) || this;
        _this.corlor = color;
        return _this;
    }
    C2.prototype.show = function () {
        console.log("MY NAME IS " + this.name);
        switch (this.corlor) {
            case colors.red:
                {
                    console.log("OUR COLOR IS " + colors.red);
                    break;
                }
            case colors.green:
                {
                    console.log("OUR COLOR IS " + colors.green);
                    break;
                }
        }
    };
    return C2;
}(C1));
exports.C2 = C2;
//#region Property Types 
var car = /** @class */ (function () {
    function car(settings) {
        this.settings = settings;
    }
    car.prototype.display = function () {
        console.log(this.settings);
    };
    return car;
}());
exports.car = car;
//#endregion
