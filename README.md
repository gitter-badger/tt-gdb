# Tucker Tech's Google Apps Drive Backup (TT-GDB)

[![Join the chat at https://gitter.im/mtuckerinaz/tt-gdb](https://badges.gitter.im/mtuckerinaz/tt-gdb.svg)](https://gitter.im/mtuckerinaz/tt-gdb?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
Tucker Tech's Free Google Apps Drive backup utility (TT-GDB) --- C# Drive API v3

Backup tool for backing up Google Apps Drive environments. This uses the Drive API v3 and C# (.net 4.5)

I developed this because I want to be able to backup my domain to my SAN & backup server. There are solutions out there, but they cost a lot of money and I'm still left in their hands. I also wanted a GUI friendly approach that I think others may be interested in the future.

This program will read a TXT file that contains only one column, which is where your useraccount@yourgappsdomain.xyz accounts are. It also supports a very rudimentary version of an LDAP AD connection. Type in your domain name and let it go.

I had a lot of trial and error with this project, so I hope others may find it useful. I will always welcome PRs if you're interested in improving it.

Please understand that I know the code is very elementary, but it's enough to get the ball rolling.

Sites of interest: http://www.tuckertechonline.com/ --- There is more information + screenshots of what to do on that page.
Directions: First, you need to setup a Google domain-wide delegation for your Google apps domain. URL for more info: https://developers.google.com/+/domains/authentication/delegation

Secondly, the code I used is mainly built on what Google already gives developers and can be found at the following URL: https://developers.google.com/drive/v3/web/quickstart/dotnet
I merely added some more "logic" to it to offer more flexibility.

At this time, I'm mainly concerned about backing up drive documents, so that's the only scope I'm pulling from, although you can really pull from any scope you want (email, drive, calendar, etc.) but those options are not native to this app yet.

Known issue(s) / concerns / future plans:

1. Create master log file for overall status. A log file is currently written for each user and streamed to their root drive directory.
2. Add restore feature

Hope this helps others who are looking for a similar solution!

To successfully build this solution, you Must create your account wide delegation service. Download the couple files you will receive from google after creating the service account. Please see the installation instructions at http://www.tuckertechonline.comn/ for more information. After you have the service and files setup, open Tucker Tech's Google Drive Backup tool, click on "Edit" then "Preferences" and fill out the key location and service email account that you created.
--
If you download the solution and plan to use it, make sure to download the NuGet repository for the Google Apps Drive (v3) tools. This can be done by opening the NuGet manager in VS and typing in: "Install-Package Google.Apis.Drive.v3" (Without quotes)

Binary download is on the releases page (https://github.com/mtuckerinaz/Gapps-backup/releases)
Please see http://www.tuckertechonline.com/ for instructions + screenshots
