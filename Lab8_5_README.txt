
LAB: Reality TV Star!
Lesson Time: 90 Minutes

Scenario:
You work for a TV network that produces hit reality TV shows. You’ve been asked to set up your company website to 
allow it to accept online applications for new contestants. There are several different TV shows and the online 
application has to ask different questions based on which show the contestants choose to apply for.

As usual, you work for a large team, and the code that you write someone else will get hooked up to an HTML form. 
Your job is to use C# inheritance to create several different classes of applications to store the answers

The TV Shows
1. Dream House Hunters
	In this show, the constant shops for their dream house and must choose from one of three. (This is based on a real tv show).

2. Paradise Island
	In this show, couples go to a tropical island where they meet singles who try to steal them and get them to break up. 
	(This is also based on a REAL tv show).

3. Above Deck
	In this show, constants work on a multi-million dollar yacht for several weeks, earning money while they serve the guests. 
	(Yep, this is a real TV show too.)


The Base Application Class
All applications need to include this data:
● First name
● Last Name
● Date of Birth
● Address
● City
● State
● Zip
● Phone Number
● Email
● Application Submitted
● Application Accepted

All applications need these methods:
Submit() - Submit will set Application Submitted to true and print to console “Application has been submitted.”

All applications need this method, will be marked virtual for overriding.
Accept() - Will set the application to accepted and print “Application Accepted”.


The House Hunter Class
The house hunter class needs to include additional data. It should have these properties
● Job Title
● Current Annual Income
● When are you Looking To Buy House
● Number of Bedrooms
● Number of Bathrooms

House Hunters class will override Accept(). The override will print “You’ve been accepted to “Dream House Hunters”


The Paradise Island Class
The paradise class needs to include this additional data. It should include these properties.
● Gender
● Name of your boyfriend/girlfriend
● Years Dating

The Paradise Island class will override Accept(). The override will print “You’ve been accepted to “Paradise Island”


The Above Deck Class
The class needs to include this additional data. It should include these properties.
● Years of experience in boating
● Nationality

The Above Deck class will override Accept(). The override will print “You’ve been accepted to “Above Deck”


Testing the Classes

In the Main program, create applications for Dream House Hunters, Paradise island, and Above deck. Submit and accept them all.

Dream House Hunter Contestant
Omar Smith
2/4/1975
111 Bravo Way
Los Angeles, California 90001
888-233-1234
omar.smith@hotmail.com
Full Stack Web Developer
$100,000
6 Months
3 Bedroom, 2 Bath


Paradise Island Contestant:
Patti Johnson
5/4/1994
211 Love Rd
Los Angeles, California 90001
988-444-1234
patti.johnson@gmail.com
Female
Carl
2 Years


Above Deck Contestant;
Captian Lee
7/12/1964
311 Bravo Way
Los Angeles, California 90001
711-333-1234
captian@gmail.com
20 years
American

To view our solution, open the 8_5RealityTV project on GitHub
