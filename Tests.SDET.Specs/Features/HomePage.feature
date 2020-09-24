Feature: Home page
	Ensure navigation options exist to social media

Scenario: Home page contains a link to Facebook
	Given I am a normal user
	When I visit the home page
	Then there is a link to facebook.com

Scenario: Home page contains a link to Twitter
	Given I am a normal user
	When I visit the home page
	Then there is a link to twitter.com

Scenario: Home page contains a link to YouTube
	Given I am a normal user
	When I visit the home page
	Then there is a link to youtube.com

Scenario Outline: Home page contains social media links 
   Given I am a normal user
   When I visit the home page
   Then there are three <URL> links of social media displayed

   Examples: 
       | URL              |
       | www.facebook.com |
       | www.youtube.com  |
       | www.twitter.com  |
