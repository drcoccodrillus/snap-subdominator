# subdominator

CLI tool for detecting subdomain takeovers.

Subdominator is an open source tool with a command line interface for identifying subdomain takeovers.
This tool comes from StratusSecurity, an Australian security company.
The source code is available at https://github.com/Stratus-Security/Subdominator

***

## Snap building
The snap can be built using snapcraft. The snapcraft.yaml file is located in the snap directory. To build the snap, use the following command:

`snapcraft`

Remember to put yourself in the snap-subdominator directory before running the command.

## Snap installation
The installation process is pretty straight forward and you can install the snap in two different ways:
- From the snap store
- From a local file

The easiest way is to install the snap from the snap store. To do so, use the following command:

`snap install subdominator`

[![Get it from the Snap Store](https://snapcraft.io/static/images/badges/en/snap-store-white.svg)](https://snapcraft.io/subdominator)


If you prefer to install the snap from a local file, follow the instructions below.

For installing the snap from a local file, use the following command:

`snap install subdominator_1.63_amd64.snap --dangerous`

## Usage
Using the snap is pretty straight forward.

To quickly check a list of domains, simply run:

`subdominator -l subdomains.txt -o takeovers.txt`

Or to quickly check a single domain, run:

`subdominator -d sub.example.com`