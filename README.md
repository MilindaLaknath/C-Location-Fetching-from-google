# C# Location latitude longitude to Address converter.

This application will help fetching Google location api Reverese lookup using latitude and longitude variables. API endpoint is https://maps.googleapis.com/maps/api/geocode/json

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
