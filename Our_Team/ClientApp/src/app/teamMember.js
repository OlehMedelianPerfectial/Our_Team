"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.TeamMember = void 0;
var TeamMember = /** @class */ (function () {
    function TeamMember(id, firstName, 
    //public title?: string,
    lastName, position, project, 
    //public hireDate?: string,
    dayOfBirth) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.position = position;
        this.project = project;
        this.dayOfBirth = dayOfBirth;
    }
    return TeamMember;
}());
exports.TeamMember = TeamMember;
//# sourceMappingURL=teamMember.js.map