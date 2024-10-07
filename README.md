# BCITAppDevAssignment
# Read Me!

# Overview of Project
This is a basic Campus Event Management System. The system helps track & manage events & ensures integration with external systems while adhering to accessibility standards.

Created for the BC Application Developer position assignment.  

The application uses the .Net framework, ASP. NET/MVC5, and utilizes SQL Server Database for back-end functionality. Its front-end is HTML/CSS/JavaScript focused. 

## Set-up instructions
Requirements to run:
- Code editor that is MVC friendly (i.e. Visual studios, VS code, etc.).
- Admin Username is "admin".
- Admin Password is "adminpass".

1. Download project zip.
2. Extract files.
3. Open solution (.sln file) or project in chosen code editor.
4. Run IIS Express.

## Limitations:
Due to time constraints...
- BC branding was not taken into consideration. 
- More fully fleshed-out testing, security, authentication, and validation should be considered in a production environment/installation.
- Some aspects of the project were only partially implemented (i.e. sessions).
- More manual and automated testing should be implemented in a production environment.

## Assumptions:
- Anything not explicitly stated in assignment documentation allowed for creative freedom on how to implement the requirement(s).  
- Application only needed to run on the latest version of windows and chrome browser.
- Datetime is an acceptable replacement for "Date" and "Time".
- Admins should be able to see ALL events, not just upcoming events.
- Quick Reference from [w3.org](https://www.w3.org/WAI/WCAG22/quickref/?versions=2.1) is a sufficient guidline for WCAG 2.1 Standards.


## Test Results
The following Manual test cases were executed. 

1. (Expected functionality): Only upcoming Events can be seen in the Event Listings page.
- Issue (Actual functionality): All (including past events) were listed.
- Fix implemented? (Y/N): Y

2.(Expected Functionality): Event Listings page displays each Event Title, Start Datetime, End Datetime, Description, and Location.
- Issue (Actual functionality): As expected.
- Fix implemented? (Y/N) : Not needed.

3. (Expected Functionality): Each Event on Event Listings page had link to view more Details.
- Issue (Actual functionality): As Expected.
- Fix implemented? (Y/N) : Not needed.

4. (Expected Functionality): Each Event on Event Listings page link redirected to appropriate View more Details page.
- Issue (Actual functionality): Link did not redirect.
- Fix implemented? (Y/N) : Y 

5. (Expected Functionality): Showed Detailed information about selected Event.
- Issue (Actual functionality): As expected.
- Fix implemented? (Y/N) : Not needed.

6. (Expected Functionality): Respective Details page displayed expected Title, Description, StartDateTime, etc.
- Issue (Actual functionality): As expected.
- Fix implemented? (Y/N) : Not needed.

7. (Expected Functionality): Respective Details page included respective Registration form to sign up for expected Event.
- Issue (Actual functionality): As expected.
- Fix implemented? (Y/N) : Not needed.

8. (Expected Functionality): Participant Registration saves to database.
- Issue (Actual functionality): Registration form did not submit/save to database.
- Fix implemented? (Y/N) : Y

9. (Expected Functionality): Admins can Create, Edit, and Delete events.
- Issue (Actual functionality): As expected.
- Fix implemented? (Y/N) : Not needed

10. (Expected Functionality): Admins can view all participants registered for all/each event.
- Issue (Actual functionality): As expected
- Fix implemented? (Y/N) : Not needed

11. (Expected Functionality): Admins can login with correct username and password.
- Issue (Actual functionality): As expected.
- Fix implemented? (Y/N) : Not needed.

12. (Expected Functionality): Admins cannot login with incorrect username or password.
- Issue (Actual functionality): As expected.
- Fix implemented? (Y/N) : Not needed.

13. (Expected Functionality): Admins can log out via logout button on Admin Panel.
- Issue (Actual functionality): As expected.
- Fix implemented? (Y/N) : Not needed.

14. (Expected Functionality): User will be asked to login into Admin Panel if they manually type an Edit URL into browser.
- Issue (Actual functionality): User will be allowed access to the Edit form for entered Event.
- Fix implemented? (Y/N) : Y.
