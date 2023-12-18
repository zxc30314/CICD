Audo Build Unity project on `push` `pull request opened` `pull request synchronize` time
Update executable file to webdav server
Notify to discord server on build success or fail

## Secrets 

### `ACCESS_TOKEN`
 Github Personal Access Tockens Access Required
 * Read access to actions, code, and metadata
 * Read and Write access to secrets
### `UNITY_USERNAME`
  Required Unity email or username
### `UNITY_PASSWORD`
  Required Unity password
### `UNITY_AUTHENTICATOR_KEY`
  Required Unity Authenictor key
  
  How to get [authenticator key](#How-to-get-Unity-authenticator-key)
  
### `UNITY_LICENSE`
  Don't  Input any value
### `DISCORD_WEBHOOK`
  Required Discord Server WebHook url
  
  How to get [Discord WebHook url](https://gist.github.com/jagrosh/5b1761213e33fc5b54ec7f6379034a22)
### `WEBDAV_ADDRESS`
  Required Webdav Server address
### `WEBDAV_USERNAME`
  Required Webdav Server address
### `WEBDAV_PASSWORD`
  Required Webdav Server address

# How to get Unity authenticator key
* Go to https://id.unity.com/en/settings/tfa/new  and click `Start setup`
* Select `Authenticator App` and click `Next`
* Click `Can't scan the barcode?`
* Save authenticator key
* Verify activation with Google Authenticator or other Authenticator app
