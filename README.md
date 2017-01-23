##CSGODirector
I created a little program which will automatically detect when the round is over and overlay a webbrowser with the twitch stream which allows you to enjoy the improved quality of GOTV, but still see players' and the crowd's reaction.

###TO INSTALL/USE:
 1. Unzip downloaded folder
 2. Set CSGO to windowed fullscreen
 3. engine_no_focus_sleep 0 (in-game console, makes it so csgo doesn't slow down when not in focus)
 4. snd_mute_losefocus 0 (in-game console, makes it so csgo still plays sound when not in focus)
 5. move the file "gamestate_integration_CSGODirector.cfg" to your csgo/cfg folder (where your autoconfig is)
 6. Restart game
 7. Watch a live match
 8. Run the CSGODirector.exe in the downloaded folder
 
 9. On the top left you can expand the settings panel
 10. Press the "'Stream URL" button and enter the twitch channel name (eleague should be default)
 11. Press the "Director" radiobutton to start the director. It will hide the twitch stream during rounds and display it during round-end/buytime
 12. Use the demoui (SHIFT+F2) to sync up GOTV and the stream

###USED LIBRARIES
[CSGSI](https://github.com/rakijah/CSGSI)
[Newtonsoft JSON](http://www.newtonsoft.com/json)
[GeckoFX](https://www.nuget.org/packages/GeckoFX/)
