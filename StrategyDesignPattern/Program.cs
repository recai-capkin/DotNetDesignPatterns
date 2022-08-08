



using StrategyDesignPattern;
using StrategyDesignPattern.Classes.UserClasses;

string user1 = "Hellchamber", user2 = "Picklerick";
ExchangeUser eu = new ExchangeUser(new OtcUser());
string otcTakerFee = eu.SetUserTakerFee(user1);
string otcMakerFee = eu.SetUserMakerFee(user1);

Console.WriteLine(otcTakerFee + "\n" + otcMakerFee);

Console.WriteLine();
eu = new ExchangeUser(new UnVerified());
string uvTakerFee = eu.SetUserTakerFee(user2);
string uvMakerFee = eu.SetUserMakerFee(user2);

Console.WriteLine(uvTakerFee+ "\n"+ uvMakerFee);