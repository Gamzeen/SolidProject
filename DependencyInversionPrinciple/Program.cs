using DependencyInversionPrinciple;

var sendEmail = new Message( new Email());
sendEmail.MessageSend(); // "E-posta gönderildi."

var sendSms = new Message( new Sms());
sendSms.MessageSend(); // "Sms gönderildi."
