# Assessment
*This is the test assessment project for the DEV program.*

The purpouse of the pagination project is to provide functionality for data navigation.
## Project structure
### Assesment project
This library provides the next functionalities for data navigation:
 * First Page, Moves cursor to the first page 
 * Previous Page,Moves cursor to the previous page. It should return an InvalidOperationException when there is no previous page.     
 * Next Page,  Moves cursor to the next page. It should return an InvalidOperationException when there is no next page.
 * Last Page, Moves cursor to the last page
 * Go To Page, moves cursor directly to the specified page. It should return an InvalidOperationException when the page is not valid. Invalid values are: negative numbers, a value that exceeds the number of pages
 * Current Page, returns the current page
 * Pages, returns the number of pages
 * Visible items, returns the elements that are visible in the current page

You can run the unit tests with the next command:

`dotnet test .\AssessmentTest\AssessmentTest.csproj`

### Assessment console
Console program that uses the library to provide data navigation to users throught the console UI.

You can run the program with the next command:

`dotnet run -p .\AssessmentConsole\AssessmentConsole.csproj`

## Goals
You must try to accomplish as many goals as possible because this will define if you are a candidate for the next advanced levels of the program.

 * Pagination 
    * Complete navigation functionalities
    * All pagination unit test must pass
    * Itendify missing scenarios to test in the Pagination code
    * Provide an implementation that can navigate a list of numbers
      * Implement the unit tests for GoToPage, NextPage and GetVisibleItems
    * Add two new functions for sorting:
      * SortAsc, sorts the data in an ascending way. The default sorting
      * SortDesc, sorts the data in a descending way 
      * Implement the unit tests
    * Modify the next methods to make them chainable
      * First page
      * Next page
      * Previous page
      * Last page
      * Go to page
      
      It should be possible to do the next calls:
      `pagination.GoToPage().NextPage();`
 * Providers   
    * Add support to data sources that are using as separator a pipe (|)
    * Add support to data sources that are using as separator a white space ( )
    * `If you think there is a better way to define Providers, feel free to refactor the code.`
    * All the provided unit tests must pass
  * Console program
    * Complete all the navigation functionalities in the Console program
    * The console program cannot crash for invalid inputs
    * `Find a better way (refactor) the spaghetti code in the App.cs code, lot of if/else sentences doesn't look good.`

# Note
Remember that the code might have issues, it is your responsibility to identify and fix them.

# Submit your task
You have 3 hours for this assignment, the way to submit your work is:
 * If you have a github account, you can clone this project and refactor the application in your clone. You must push your changes before the time limit.
 After that send an email to alejandro.ruiz@fundacion-jala.org with the url of your repository.
 * If you are not familiar with git repositories, you can download the project from the next url:
 https://github.com/ziur/dev-program-assessment/archive/master.zip
 To submit your changes, you can zip your project folder and send it to alejandro.ruiz@fundacion-jala.org before the time limit.  
 **NOTE:** Please make sure only include project files. 
 