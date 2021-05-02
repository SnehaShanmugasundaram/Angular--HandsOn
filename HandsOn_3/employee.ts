export interface Employee{
    Id:number
    Name:string
    Salary:number
    Permanent:boolean,
    department:Department;
    skills:Skill[];

}
import {Department} from './department'
import {Skill} from './skill'

//export var Departments:IDepartment;



