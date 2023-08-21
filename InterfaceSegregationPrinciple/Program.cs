using InterfaceSegregationPrinciple;

var recruiter = new Recruiter();
var teamLead = new TeamLead();
var srDeveloper = new SrDeveloper();
var jrDeveloper = new JrDeveloper();


recruiter.Recruitment();
recruiter.Mentor();

teamLead.Recruitment();
teamLead.Development();
teamLead.Mentor();

srDeveloper.Development();
srDeveloper.Mentor();

jrDeveloper.Development();