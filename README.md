# Notification Demo

This repository shows how to connect to the SignalR Hub of the Gearbox3d HT2 and relay 'Print Complete' messages elsewhere. 

For a .net application you need to install `Microsoft.AspNetCore.SignalR.Client` to subscribe to the SignalR Hub built into the HT2 HMI. 

Add logic to the 'PrintComplete' event to POST to a Web API so you can receive completion notification messages wherever you would like.

Here are some references on how to post messages to common chat apps programatically

- ### [Microsoft Teams Webhook](https://docs.microsoft.com/en-us/microsoftteams/platform/webhooks-and-connectors/how-to/connectors-using?tabs=cURL)
- ### [Slack](https://api.slack.com/messaging/sending)
- ### [Google Chat](https://developers.google.com/chat/api/reference/rest)