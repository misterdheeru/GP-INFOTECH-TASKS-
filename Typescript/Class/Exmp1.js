"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Students = void 0;
var Students = /** @class */ (function () {
    function Students(id, name) {
        this.id = id;
        this.name = name;
    }
    Students.prototype.Show = function () {
        console.log("ID : " + this.id);
        console.log("NAME : " + this.name);
    };
    return Students;
}());
exports.Students = Students;
