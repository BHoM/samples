# Loadcases and Combinations Excel sample

This Excel workbook can be used to create a collection of loadcases and
combinations for use with structural analysis software (e.g. via
[`Robot_Toolkit`]).

It is configured to send the generated objects over a Socket using the
[`Socket_Toolkit`] it is recommended to link these to geometries using the
[Grasshopper UI plugin] and send the loadcases and geometries to your
structural analysis from there.

## Sheets

### Loadcases

This Sheet creates [`Loadcase`] objects.

### Loads

This sheet creates [`Load`] objects based upon the `Loadcases` from the
previous sheet.

### Load Combinations

This sheet creates [`LoadCombination`] objects based upon all of the
`Loadcases` from the previous sheet combined with a weighting for each.

### Adapter

Pushes `Loadcase`s, `Load`s and `LoadCombination`s to three respective
[`SocketAdapter`]s to be Pulled from another `SocketAdapter` for use with other
tools.

[`Robot_Toolkit`]: https://github.com/BHoM/Robot_Toolkit
[`Socket_Toolkit`]: https://github.com/BHoM/Socket_Toolkit
[`Loadcase`]: https://github.com/BHoM/BHoM/blob/master/Structure_oM/Loads/Loadcase.cs
[`Load`]: https://github.com/BHoM/BHoM/blob/master/Structure_oM/Loads/Load.cs
[`LoadCombination`]: https://github.com/BHoM/BHoM/blob/master/Structure_oM/Loads/LoadCombination.cs
[Grasshopper UI plugin]: https://github.com/BHoM/Grasshopper_Toolkit
[`SocketAdapter`]: https://github.com/BHoM/Socket_Toolkit/tree/master/Socket_Adapter
