using DependencyInversionPrinciple;

var sendEmail = new Message( new Email());
sendEmail.MessageSend(); 

var sendSms = new Message( new Sms());
sendSms.MessageSend(); 

