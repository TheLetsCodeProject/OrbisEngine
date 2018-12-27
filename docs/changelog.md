# The OrbisEngine Development Archive
***
# v0.0.1-Dev.10.11.18 [Unreleased]
- Migrating documentation and issue tracking to GitHub


# v0.0.1-Dev.5.11.18 [Unreleased]
- Barebones implementation of IMC system. Operational as a VMP or proof of concept.
- Some planning and sketch up of serialization back end

# v0.0.1-Dev.26.12.18 [Unreleased]
- Added Stat support to the IMC system. This allows for the dynamic shifting of stats.
- Minor API changes to the Item class. It is now possible to recieve messages through a 'message handler' which can be assigned using the 'messageHandlers' dictionary. Note that 'HandleMessage' can still be overriden directly.
- Added more component protoypes to the project
- Change the the version format to stay more in line with SemVer (Semantic Versioning)
- Minor API changes to the Item class. 'GetComponent' method is now provided. GetComponent will return null if no such component is found