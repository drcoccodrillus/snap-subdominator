﻿namespace Subdominator;

public class Options
{
    public string Domain { get; set; }
    public string DomainsFile { get; set; }
    public string OutputFile { get; set; }
    public int Threads { get; set; }
    public bool Verbose { get; set; }
}
