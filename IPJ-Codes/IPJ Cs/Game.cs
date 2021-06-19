﻿using System;
using System.Collections.Generic;
using System.Text;


class Game
{
    enum State {Gameplay, Pause}
    private GamePlay gameplay;
    private PauseMenu pauseMenu;
    private static State state;

    public Game() {
        gameplay = new GamePlay();
        pauseMenu = new PauseMenu();
    }

    public void Update() {
        switch (state) {
            case State.Gameplay:
                gameplay.Play();
                break;
            case State.Pause:
                pauseMenu.Pause();
                break;
        }
    }

    public static void GoToPause() {
        state = State.Pause;
    }

    public static void GoToGamePlay()
    {
        state = State.Gameplay;
    }
}

