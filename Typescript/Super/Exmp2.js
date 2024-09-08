"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.DisplayStudents = void 0;
var Exmp1_1 = require("./Exmp1");
var DisplayStudents = /** @class */ (function () {
    function DisplayStudents() {
    }
    DisplayStudents.prototype.display = function () {
        var Data = { ID: 1, NAME: "RAMA", CLASS_NAME: "V", AGE: 25 };
        var std1 = new Exmp1_1.college();
        std1.show(Data);
    };
    return DisplayStudents;
}());
exports.DisplayStudents = DisplayStudents;
// var res  = new DisplayStudents()
// res.display()
// var res2 = new C2("RAMA",colors.red)
// res2.show();
var car1 = new Exmp1_1.car("RAMA");
car1.display();
