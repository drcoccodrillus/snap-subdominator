![GitHub Actions CI](https://github.com/Stratus-Security/Subdominator/workflows/CI/badge.svg)
![GitHub all releases](https://img.shields.io/github/downloads/Stratus-Security/Subdominator/total)

# Subdominator 🚀

## Welcome to the Subdominator Club!
Meet **Subdominator**, your new favourite CLI tool for detecting subdomain takeovers. It's designed to be fast, accurate, and dependable, offering [a significant improvement over other available tools](https://www.stratussecurity.com/post/the-ultimate-subdomain-takeover-tool).

🔍 Precision and speed are our goal. Subdominator delivers better results without the wait, see the benchmark and feature comparison below for details.

## Installing 🛠️
To quickly, get up and running, you can download the latest release for [windows](https://github.com/Stratus-Security/Subdominator/releases/latest/download/Subdominator.exe) or [linux](https://github.com/Stratus-Security/Subdominator/releases/latest/download/Subdominator).
Alternatively, download it via CLI (remove .exe for linux version):
```base
wget https://github.com/Stratus-Security/Subdominator/releases/latest/download/Subdominator.exe
```

## Quick Start 🚦
To quickly check a list of domains, simply run: 
```
Subdominator.exe -l subdomains.txt -o takeovers.txt
```
Or to quickly check a single domain, run:
```
Subdominator.exe -d sub.example.com
```

## Options 🎛️
```
-d, --domain <domain>    A single domain to check
-l, --list <list>        A list of domains to check (line delimited)
-o, --output <output>    Output subdomains to a file
-t, --threads <threads>  Number of domains to check at once [default: 50]
-v, --verbose            Print extra information
-eu, --exclude-unlikely  Exclude unlikely (edge-case) fingerprints
--validate               Validate the takeovers are exploitable (where possible)
--version                Show version information
-?, -h, --help           Show help and usage information
```

## Demo
The tool was run across 1000 passively gathered subdomains:
![Demo](https://raw.githubusercontent.com/Stratus-Security/Subdominator/master/Demo.gif)

## Benchmark 📊
A benchmark was run across ~100,000 subdomains to compare performance with other popular tools
| Tool         | Threads | Time Taken         |
|--------------|---------|--------------------|
| **Subdominator** | 50      | 19 minutes, 8 seconds |
| Subjack      | 50      | 2 hours, 30 minutes, 2 seconds |
| Subdover     | 50      | 2 hours, 33 minutes, 27 seconds |

## Key Features 🔥
- **Advanced DNS Matching**: Supports DNS matching for CNAME, A, and AAAA records.
- **Recursive DNS Queries**: Performs in-depth queries to enhance accuracy and reduce false positives.
- **Intelligent Domain Matching**: Uses a custom `public_suffix_list.dat` for more effective domain matching.
- **Domain Registration Detection**: Checks for unregistered domains, with a more reliable method compared to other tools.
- **High-Speed Performance**: Achieves faster results through intelligent DNS record matching.
- **Vetted Ruleset**: Includes a thoroughly reviewed and updated ruleset.
- **Comprehensive Detection**: Capable of identifying takeovers missed by other tools.
- **Validation**: Dynamic takeover validation modules to check beyond fingerprints.

## Feature Comparison 🥊
| Feature                          | Subdominator | Subjack | Subdover |
|----------------------------------|--------------|---------|----------|
| Advanced DNS Matching            | ✅          | ❌      | ❌       |
| Recursive DNS Queries            | ✅          | ❌      | ❌       |
| Intelligent Domain Matching      | ✅          | ❌      | ❌       |
| Domain Registration Detection    | ✅          | ✅      | ❌       |
| High-Speed Performance           | ✅          | ❌      | ❌       |
| Vetted and Updated Ruleset       | ✅          | ❌      | ❌       |
| Comprehensive Detection          | ✅          | ❌      | ❌       |
| Custom Fingerprint Support       | ✅          | ✅      | ❌       |
| Validation                       | ✅          | ❌      | ❌       |
| Fingerprints                     | 97           | 35      | 80       |

## Contributions
Got a suggestion, fingerprint, or want to chip in? We're all ears! Open a PR or issue – this will keep subdominator on top! 😄
