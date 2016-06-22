# C-Location-Fetching-from-google

This application will help fetching Google location api Reverese lookup using Lat and Lang variables.

Following return's can be used.

```
                 +---------+
            +---^+ Status  |
+-------------+  +---------+
| Root object |
+-------------+  +---------+     +-----------------------------------------+
            +---^+ Result  +-+--->String place_id                          |
                 +---------+ |   +-----------------------------------------+
                             |   +-----------------------------------------+
                             +--->String formatted_address                 |
                             |   +-----------------------------------------+
                             |   +-----------------------------------------+
                             +--->List<AddressComponent> address_components|
                             |   +-----------------------------------------+
                             |   +-----------------------------------------+
                             +--->Geometry geometry                        |
                             |   +-----------------------------------------+
                             |   +-----------------------------------------+
                             +--->List<string> types                       |
                                 +-----------------------------------------+

```
