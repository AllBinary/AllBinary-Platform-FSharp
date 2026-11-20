namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2026 AllBinary
 *
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 *
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 *
 * Created By: Travis Berthelot
 * 
 *)

[<AllowNullLiteral>]
type MIDPUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : MIDPUtil
    static member instance with get() : MIDPUtil = (MIDPUtil.jclinit(); MIDPUtil.jcell_instance) and set (jvalue: MIDPUtil) = (MIDPUtil.jclinit(); MIDPUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MIDPUtil.jclinitDone then
            MIDPUtil.jclinitDone <- true
            MIDPUtil.jclinitBody()
    static member private jclinitBody() : unit =
        MIDPUtil.jcell_instance <- (new MIDPUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : MIDPUtil =
        MIDPUtil.instance
    
    abstract createImageWH : width: int * height: int -> Image
    default this.createImageWH(width: int, height: int) : Image =
        Image.createImageWH(width, height)
    
    abstract createImageFromByteArray : imageData: sbyte[] * imageOffset: int * imageLength: int -> Image
    default this.createImageFromByteArray(imageData: sbyte[], imageOffset: int, imageLength: int) : Image =
        Image.createImageFromByteArray(imageData, imageOffset, imageLength)
    
    abstract createImageFromInputStream : inputStream: InputStream -> Image
    default this.createImageFromInputStream(inputStream: InputStream) : Image =
        Image.createImageFromInputStream(inputStream)
    
    abstract createPlayerFromInputStream : inputStream: InputStream * type_: string -> Player
    default this.createPlayerFromInputStream(inputStream: InputStream, type_: string) : Player =
        Manager.createPlayerFromInputStream(inputStream, type_)
    
    abstract appendItem : form: Form * item: LcduiItem -> int
    default this.appendItem(form: Form, item: LcduiItem) : int =
        form.appendItem(item)


