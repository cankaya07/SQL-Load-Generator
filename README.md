# SQL Load Generator
SQL Load Generator is used to run multiple concurrent queries against SQL Server. The user can choose the number of concurrent queries to run, provide different queries, choose SQL or domain accounts, and provide application name settings. SLG was developed using C# 3.5.

forked from this repo <a href="https://archive.codeplex.com/?p=sqlloadgenerator">Codeplex SqlLoadGenerator</a>

Project Description
SQL Load Generator is used to run multiple concurrent queries against SQL Server. The user can choose the number of concurrent queries to run, provide different queries, choose SQL or domain accounts, and provide application name settings. SLG was developed using C# 3.5.

A few weeks ago I spoke at PASS on using the Resource Governor in SQL Server 2008. For my demo, I created a little application that could fire off multiple queries against SQL Server to simulate different users/applications. This tool… gasp… creates a load on SQL Server. People seemed interested in the application, so I’ve decided to release it on CodePlex.

For anyone that saw that demo, this tool has gotten a a bit of a face lift… I sort of got bored over the holidays, and added a few features that I wished I had when I was using it to demo, as well as just playing around. It’s nothing fancy… I just put it together one Saturday for my presentation, then gave into some feeping creaturism a couple of nights. 

I originally created this to test settings for the SQL Server 2008 Resource Governor. You can also use it as a (very) light weight load testing tool, but no promises on that. I’m not planning on adding any features to it, or supporting it much, but I thought I’d put it out there.

Here’s what it looks like:



Here’s a summary of the features:
Runs multiple queries against SQL Server. You can add as many as you like.
Each query can be either a SQL User or Domain User.
You can specify an Application name for the connection.
You can specify the new of concurrent threads to use for each query.
You can start all queries, stop all queries, remove all queries.
There is logging (you can toggle on and off… it isn’t precisely thread safe, and can cause crashes when there are lots of failures on multiple threads) for failed queries.
You can set all the defaults on a per user basis, and persist them.
Each query has a # of Runs and a # of Fails counter. You can use the ‘Reset Counters’ feature to reset the total counts (not the per query counts).

You can save your settings via the ‘Options’ menu. You can add default items to the different dropdowns, provide default query settings, change the log locations, etc. You can also modify the stock connection string… though keep in mind some of the settings (particularly ‘pooling=false’ will affect the way the application works… namely, the connections to SQL Server won’t be closed). 
