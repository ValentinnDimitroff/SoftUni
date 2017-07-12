﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRunning;
    private NationsBuilder nationsBuilder;

    public Engine()
    {
        this.isRunning = true;
        this.nationsBuilder = new NationsBuilder();
    }

    public void Run()
    {
        while (this.isRunning)
        {
            string inputCommand = this.ReadInput();
            List<string> commandParameters = this.ParseInput(inputCommand);
            this.DistributeCommand(commandParameters);
        }
    }

    private void DistributeCommand(List<string> commandParameters)
    {
        string command = commandParameters[0];
        commandParameters.Remove(command);

        switch (command)
        {
            case "Bender":
                this.nationsBuilder.AssignBender(commandParameters);
                break;
            case "Monument":
                this.nationsBuilder.AssignMonument(commandParameters);
                break;
            case "Status":
                string status = this.nationsBuilder.GetStatus(commandParameters[0]);
                this.OutputWriter(status);
                break;
            case "War":
                this.nationsBuilder.IssueWar(commandParameters[0]);
                break;
            case "Quit":
                string record = this.nationsBuilder.GetWarsRecord();
                this.OutputWriter(record);
                this.isRunning = false;
                break;
        }
    }

    private void OutputWriter(string status) => Console.WriteLine(status);
    private List<string> ParseInput(string inputCommand) => inputCommand.Split(' ').ToList();
    private string ReadInput() => Console.ReadLine();
}