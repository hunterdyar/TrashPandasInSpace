﻿// using System.Collections.Generic;
// using UnityEngine;
//
// namespace Player
// {
// 	public class PlayerConnectionHandler : MonoBehaviour
// 	{
// 		//Searches for input/connections from possible devices. When it finds one, it creates a new player.
// 		 public GameObject PlayerPrefab;
//     public Transform spawnLocation;
//     
//     private Dictionary<PlayerIndex, GameObject> _players = new Dictionary<PlayerIndex, GameObject>();
//
//     public bool searchForMoreControllers;
//
//     public ControllerIndex defaultControllerIndex = ControllerIndex.Right;
//     
//     // Update is called once per frame
//     void Update()
//     {
//         //really do this every frame? Should probably just react to input or a button press on 'any' controller.
//         if (searchForMoreControllers)
//         {
//             for (int i = 1; i <= 4; i++)
//             {
//                 var pindex = (PlayerIndex)i; //we can cast an int to an enum. Conveniently, one is 1, two is 2, etc. 
//                 if (TiltFive.Player.IsConnected(pindex) && !_players.ContainsKey(pindex))
//                 {
//                     SpawnPlayer(pindex);
//                     //got all expected?
//                     if (i == 4)
//                     {
//                         searchForMoreControllers = false;
//                     }   
//                 }
//             }
//         }
//     }
//
//     void SpawnPlayer(PlayerIndex player)
//     {
//         var p = Instantiate(PlayerPrefab,spawnLocation.position,spawnLocation.rotation);
//         
//         //configure input
//         var input = p.GetComponent<InputReader>();
//         input.PlayerIndex = player;
//         
//         //todo: yield here for WaitUntilWandConnected
//
//         var controller = p.GetComponent<CharacterManager>();
//
//         //The controller uses the camera to re-orient input from the axis to be relative.
//         //We set it to one of the tracked objects of the wand in order to make it relative to literally how the controller is oriented.
//         controller.characterCamera = TiltFiveManager2.Instance.allPlayerSettings[(int)player - 1].rightWandSettings.AimPoint;
//
//         if(TiltFive.Player.TryGetFriendlyName(player,out var friendlyName))
//        {
//            p.name = "Player - " + friendlyName;
//        }
//         
//         //todo: configure visuals
//             
//         //add to dictionary
//         _players.Add(player,p);
//
//     }
// 	}
// }// using System.Collections.Generic;
// using UnityEngine;
//
// namespace Player
// {
// 	public class PlayerConnectionHandler : MonoBehaviour
// 	{
// 		//Searches for input/connections from possible devices. When it finds one, it creates a new player.
// 		 public GameObject PlayerPrefab;
//     public Transform spawnLocation;
//     
//     private Dictionary<PlayerIndex, GameObject> _players = new Dictionary<PlayerIndex, GameObject>();
//
//     public bool searchForMoreControllers;
//
//     public ControllerIndex defaultControllerIndex = ControllerIndex.Right;
//     
//     // Update is called once per frame
//     void Update()
//     {
//         //really do this every frame? Should probably just react to input or a button press on 'any' controller.
//         if (searchForMoreControllers)
//         {
//             for (int i = 1; i <= 4; i++)
//             {
//                 var pindex = (PlayerIndex)i; //we can cast an int to an enum. Conveniently, one is 1, two is 2, etc. 
//                 if (TiltFive.Player.IsConnected(pindex) && !_players.ContainsKey(pindex))
//                 {
//                     SpawnPlayer(pindex);
//                     //got all expected?
//                     if (i == 4)
//                     {
//                         searchForMoreControllers = false;
//                     }   
//                 }
//             }
//         }
//     }
//
//     void SpawnPlayer(PlayerIndex player)
//     {
//         var p = Instantiate(PlayerPrefab,spawnLocation.position,spawnLocation.rotation);
//         
//         //configure input
//         var input = p.GetComponent<InputReader>();
//         input.PlayerIndex = player;
//         
//         //todo: yield here for WaitUntilWandConnected
//
//         var controller = p.GetComponent<CharacterManager>();
//
//         //The controller uses the camera to re-orient input from the axis to be relative.
//         //We set it to one of the tracked objects of the wand in order to make it relative to literally how the controller is oriented.
//         controller.characterCamera = TiltFiveManager2.Instance.allPlayerSettings[(int)player - 1].rightWandSettings.AimPoint;
//
//         if(TiltFive.Player.TryGetFriendlyName(player,out var friendlyName))
//        {
//            p.name = "Player - " + friendlyName;
//        }
//         
//         //todo: configure visuals
//             
//         //add to dictionary
//         _players.Add(player,p);
//
//     }
// 	}
// }