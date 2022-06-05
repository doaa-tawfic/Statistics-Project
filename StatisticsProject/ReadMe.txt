CONTENTS OF THIS FILE
---------------------
 * Introduction
 =================
	This project is basicaly consisting of a single endpoint that basically works on retrieving historical 
	exchange rates from the API available at "https://exchangerate.host/" to get some statistics of data provided 
	for certain historical dates.
 *******************************************************************************************************
 * Requirements
 ===============
	the API requirements should accept as input 
		a. set of dates.
		b. base currency. 
		c. the convertion rate currency.
	and should generate 
		1. Minimun value for the exchange rate in given dates specifying the date that matches this occurance.
		2. Maximun value for the exchange rate in given dates specifying the date that matches this occurance.
		3. Average value of exchange rates over the whole set of dates. 
 
 *******************************************************************************************************
 * Installation
 ===============
 For further development=>
	this application was developed using Visual studio 2019 community edition. and it's based on .NETCore 3.1
	the solution contains 2 projects (ExchangeRates and ExchangeRates.Test )
	ExchangeRates=> the basic project that contains the business logic of the endpoint.
	ExchangeRates.Test=> the test case for our endpoint is defined in the test project.

	some Extra Nuget packages where added to the project 
	Microsoft.AspNetCore.MVC.NewtonsoftJson (3.1.25) -> for json 
	Swashbuckle.ASPNetCore (6.3.1) -> for swagger "api documentation"


 For deployment and hosting => 
	the best tutorial that contains a step by step guide for the deployment of the project on IIS can be found 
	here: "http://varunatluri.com/asp-net-core-3-1-web-api-hosting-and-deployment-in-iis/"
	the published project files can be found on published project files folder. you can use postman after for testing


