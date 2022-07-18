# Notification Demo

This repository shows how to connect to the SignalR Hub of the Gearbox3d HT2 and relay 'Print Complete' messages elsewhere. 

For a .net application you need to install `Microsoft.AspNetCore.SignalR.Client` to subscribe to the SignalR Hub built into the HT2 HMI. 

There are currently 2 events that will send a message out with SignalR. You can subscribe to these messages and relay them wherever is best applicable for your organization.

- `PrintComplete` will send a short string containing the print duration upon print completion.
- `RunoutDetected` will send a message when the machine runs out of material during a print. This notification currently will be sent whether or not there is backup material loaded.

Here are some references on how to post messages to common chat apps programatically

- ### [Microsoft Teams Webhook](https://docs.microsoft.com/en-us/microsoftteams/platform/webhooks-and-connectors/how-to/connectors-using?tabs=cURL)
- ### [Slack](https://api.slack.com/messaging/sending)
- ### [Google Chat](https://developers.google.com/chat/api/reference/rest)
