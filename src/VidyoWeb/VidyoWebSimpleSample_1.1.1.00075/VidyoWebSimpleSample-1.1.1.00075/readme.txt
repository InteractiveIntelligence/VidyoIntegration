This sample is designed to take as a URL argument all the needed parameters to auto-join into a conference as a guest. 

Below is a complete example of how to utilize the site.
http://www.samplesite.com/index.html?portalUri=https://VIDYOPORTAL.com/flex.html?roomdirect.html&key=XXXXXXXX&guestName=Guest+User&roomPin=1234

Main URL:
http://www.samplesite.com/index.html - this is the site itself. You can run the site from a development PC for testing or hosted on a proper web server.

Arguments:
encoded   - This is an important, but optional argument. 
            When set to 1, the site will decode the portalURI parameter that is HTML encoded (%26 instead of '&', etc) before processing. This is common when passing from another webpage or backend service.
            When set to 0 or missing, the site will read the portalURI parameter directly.
portalUri - This is the only mandatory field, and is the complete guest link one would get from the VidyoPortal.
guestName - This is an optional, but useful field used to automatically specify the guest user's name in the conference. Leaving this blank will set the user's display name to "Guest".
roomPin   - This is an optional field used to auto-join a Vidyo conference room that is PIN-protected. Not populating this field will prevent joining a PIN-protected room.

Organization of this Sample package:
readme.txt - this file
JS_Documentation/ - this is the Javascript reference documentation
Sample/ - this is the actual sample site directory.
