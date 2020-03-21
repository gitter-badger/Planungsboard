﻿using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace Planungsboard.Presentation.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            LoadedCommand = new RelayCommand(LoadedCommandHandling);

            this.DisplayQuarters = new List<string>()
            {
                "Q1-2020",
                "Q2-2020",
                "Q3-2020",
                "Q4-2020",
            };

            this.Teams = new List<Team>()
            {
                new Team()
                {
                    Name = "Dev-Team #1",
                    Cards = CreateDebugData_Cards(),
                },
                new Team()
                {
                    Name = "Dev-Team #2",
                    Cards = CreateDebugData_Cards(),
                },
            };
        }

        #region Properties

        public List<String> DisplayQuarters { get; set; }
        public List<Team> Teams { get; set; }
        private double teamLabelWidth;

        public double TeamLabelWidth
        {
            get => teamLabelWidth;
            set => base.Set(ref teamLabelWidth, value);
        }

        #endregion

        #region Commands

        public RelayCommand LoadedCommand { get; set; }

        #endregion

        #region Commands Handling

        private void LoadedCommandHandling()
        {
           
        }

        #endregion

        #region Helper

        private static List<Card> CreateDebugData_Cards()
        {
            return new List<Card>()
            {
                new Card()
                {
                    LeftMargin = 1,
                    RightMargin = 2,
                    Id = "123",
                    Effort = 12,
                    Title = "TIZU"
                },
                new Card()
                {
                    LeftMargin = 0,
                    RightMargin = 0,
                    Id = "456",
                    Effort = 12,
                    Title = "TuFp"
                },
                new Card()
                {
                    LeftMargin = 2,
                    RightMargin = 1,
                    Id = "789",
                    Effort = 12,
                    Title = "BER"
                },
                new Card()
                {
                    LeftMargin = 3,
                    RightMargin = 0,
                    Id = "234",
                    Effort = 12,
                    Title = "YQml"
                },
            };
        }

        #endregion
    }


    public class Card
    {
        public double LeftMargin { get; set; }
        public double RightMargin { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public int Effort { get; set; }
    }

    public class Team
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
    }
}