# QuickHash
A simple hashing utility for Metal Gear Solid V and Metal Gear: Survive

## Usage
### Standard Usage
1. Enter the string you wish to hash in the *String* text box.

2. Choose a hash type from the available options.

3. Check the *Little-Endian* checkbox if you want the hash to be formatted as Little-Endian.

4. Click the *Process* button.

5. Done! Your hash will appear in the *Hash* text box.

**Note**: Path names should begin with a forward slash, and only use forward slashes.

**Note 2**: Capitalization matters! *Assets* is not the same as *assets*!

**Example of a correctly entered filename**:

>/Assets/tpp/chara/qui/Pictures/qui0_face0_def_bsm

Using the example above, you would receive the following as the output when using the PathCode64 hash type:

>245f7164a964b

### Command-Line Usage
QuickHash can be used via command line for batch operations.

The first argument should be the string you are hashing.

The second argument should be the hash type.

**Hash Types**:

>**-p64**: PathCode64

>**-p64e**: PathCode64 with Extension

>**-s64**: StrCode64

>**-p32**: PathCode32

>**-s32**: StrCode32

>**-e**: Extension Bytes

The third argument is optional. Provide a *-l* argument if you want the hash to be output in the Little-Endian format.

**Example**:

> QuickHash /Assets/tpp/chara/qui/Pictures/qui0_face0_def_bsm.ftex -p64e -l >> output.txt

This will output:

> 4b964a16f7456a15
