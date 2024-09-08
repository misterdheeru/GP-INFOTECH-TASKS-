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
exports.Cat = exports.Dog = exports.Animals = exports.Football = exports.Cricket = exports.Sports = void 0;
var Sports = /** @class */ (function () {
    function Sports(name) {
        this.name = name;
        console.log("My Favorite Sports Name is : " + this.name);
    }
    Sports.prototype.Play = function () {
        console.log("My Favorite Sports Name is : " + this.name);
    };
    return Sports;
}());
exports.Sports = Sports;
var Cricket = /** @class */ (function (_super) {
    __extends(Cricket, _super);
    function Cricket(name) {
        return _super.call(this, name) || this;
    }
    Cricket.prototype.Play = function () {
        console.log("I LOVE PLAYING CRICKET");
    };
    return Cricket;
}(Sports));
exports.Cricket = Cricket;
var Football = /** @class */ (function (_super) {
    __extends(Football, _super);
    function Football(name) {
        return _super.call(this, name) || this;
    }
    Football.prototype.Play = function () {
        console.log("I LOVE PLAYING FOOTBALL");
    };
    return Football;
}(Sports));
exports.Football = Football;
var cricket = new Cricket("CRICKET");
var football = new Football("FOOTBALL");
cricket.Play();
football.Play();
var Animals = /** @class */ (function () {
    function Animals(name) {
        this.name = name;
    }
    Animals.prototype.DisplayName = function () {
        console.log("My Favorite Animal  is : " + this.name);
    };
    return Animals;
}());
exports.Animals = Animals;
var Dog = /** @class */ (function (_super) {
    __extends(Dog, _super);
    function Dog(name) {
        return _super.call(this, name) || this;
    }
    Dog.prototype.makesound = function () {
        console.log("Dog Tells Bow Bow....");
    };
    return Dog;
}(Animals));
exports.Dog = Dog;
var Cat = /** @class */ (function (_super) {
    __extends(Cat, _super);
    function Cat(name) {
        return _super.call(this, name) || this;
    }
    Cat.prototype.makesound = function () {
        console.log("Cat Tells Meawoooo....");
    };
    return Cat;
}(Animals));
exports.Cat = Cat;
var dog = new Dog("Jack");
var cat = new Cat("Memoo");
dog.DisplayName();
dog.makesound();
cat.DisplayName();
cat.makesound();
