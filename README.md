# CuffConversion Plugin

CuffConversion is a lightweight and flexible Exiled plugin for SCP: Secret Laboratory. It allows players to switch teams upon escaping while cuffed, based on who cuffed them.

## Features

- Converts Chaos Insurgency players to MTF when escaping while cuffed by an MTF unit.
- Converts MTF players to Chaos when escaping while cuffed by a Chaos Insurgency unit.
- Fully configurable messages, timings, and conversion toggles.
- Simple and clean implementation using Exiled's Player Events.

## Requirements

- SCP: Secret Laboratory (latest version) : 14.1.0 
- Exiled API v9.6.0 or newer
- .NET Standard 2.0 support (for building)

## Installation

1. Download the compiled DLL and place it in your `plugins` folder.
2. Start the server to generate the configuration file.
3. Modify `CuffConversion.yml` in the `config` folder to fit your preferences.

## Configuration

Below is an example of the configuration file:

```yaml
cuff_conversion:
  is_enabled: true
  convert_chaos_to_mtf: true
  convert_mtf_to_chaos: true
  broadcast_duration: 5
  chaos_to_mtf_message: "<color=green>You have been converted to MTF after escaping!</color>"
  mtf_to_chaos_message: "<color=red>You have been converted to Chaos after escaping!</color>"
 ```
| Option                 | Description                                                    |
| ---------------------- | -------------------------------------------------------------- |
| `is_enabled`           | Enables or disables the entire plugin.                         |
| `convert_chaos_to_mtf` | Converts Chaos players to MTF when cuffed by MTF and escape.   |
| `convert_mtf_to_chaos` | Converts MTF players to Chaos when cuffed by Chaos and escape. |
| `broadcast_duration`   | Duration in seconds for conversion messages to appear.         |
| `chaos_to_mtf_message` | Message shown when a Chaos player is converted to MTF.         |
| `mtf_to_chaos_message` | Message shown when an MTF player is converted to Chaos.        |
-------------------------------------------------------------------------------------------
## Target Plugin:
1. .Config / Exiled / Plugins / put dll file there
2. SCPSL / Managed / Exiled / Plugin / put dll file
3. The version for Labapi comme soon
### ENJOY


