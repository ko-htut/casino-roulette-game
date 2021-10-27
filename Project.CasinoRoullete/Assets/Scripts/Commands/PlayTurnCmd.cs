using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ViewModel;
using Controllers;

namespace Commands
{    
    public class PlayTurnCmd : ICommand
    {
        public void Execute()
        {
            PlayerSound.Instance.gameSound.OnSound.OnNext(0);
        }
    }
}