"use strict";
exports.__esModule = true;
var emp = {
    Id: 101,
    Name: "Sri",
    Salary: 20000,
    Permanent: true,
    department: {
        DeptID: 201,
        DeptName: "Payroll"
    },
    skills: [{ SkillId: 301, SkillName: "HTML" }, { SkillId: 302, SkillName: "CSS" }, { SkillId: 303, SkillName: "Javascript" }]
};
console.log("id: " + emp.Id);
console.log("name: " + emp.Name);
console.log("salary: " + emp.Salary);
console.log("permanent: " + emp.Permanent);
console.log("department id: " + emp['department'].DeptID);
console.log("department name: " + emp['department'].DeptName);
console.log("skill 1 : " + emp['skills'][0].SkillId + "," + emp['skills'][0].SkillName);
console.log("skill 2 : " + emp['skills'][1].SkillId + "," + emp['skills'][1].SkillName);
console.log("skill 3 : " + emp['skills'][2].SkillId + "," + emp['skills'][2].SkillName);