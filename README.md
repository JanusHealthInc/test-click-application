# Test Click Application

This application is a simple Windows Forms Application on .NET 6.0 that is meant to:

1. Report the number of clicks that a user makes anywhere on their windows system to a click server
2. Poll the click server to see what the aggregated number of the clicks is
3. Allow the user to reset their click count

The click server in question: https://github.com/JanusHealthInc/node-click-counter

## Interview Start:

### Familiarize yourself:  

1. Please take a look at the instantiation that we do at the Program level.

2. You can run the application and see a mock "click" count being activated

### Prompts

1. Form1.cs is written with a dummy counter function.  Please wire it to connect to the API.

2. SystemObserver is written to listen for a Mouse Low Level Event, however it needs to have a way for us to 
be able to send this information to the server. Please update the mouseHookProc() method.

	- A way to send the API data

	- Actually implementing the mouseHookProc() method

**Milestone 1:** The application should be tallying clicks

3. Please add a Button to reset the click count on the server

**Milestone 2:** The application should reset the click value on refresh

4. Let's modify the server and application to track and report left and right clicks

**Milestone 3:** The application should report left and right clicks



## About the repo

### ClickApi

This contains a service to our click server.

### OS

This contains OS related functionality - particularly the SystemObserver that hooks into the OS Hooks APIs.

### WinAPI

This contains abstractions of the Windows C++ driver APIs.

### UI

This contains our simple form components

## Future Scope - Follow up questions

How would we go about parameterizing the application for each testing location?

How would we go about parameterizing the application for each organization that we deliver it to? (i.e. a different DNS server name)

What design patterns would you have liked to change?

How would you set up the deployment of updates for this application?
