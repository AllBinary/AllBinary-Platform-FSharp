namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2011 AllBinary 
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
type TrueTypeFontUtil =
    inherit TrueTypeFontUtilBase
    [<DefaultValue(false)>] val mutable fontImage : OpenGLESImage
    [<DefaultValue(false)>] static val mutable private jcell_instance : TrueTypeFontUtil
    static member instance with get() : TrueTypeFontUtil = (TrueTypeFontUtil.jclinit(); TrueTypeFontUtil.jcell_instance) and set (jvalue: TrueTypeFontUtil) = (TrueTypeFontUtil.jclinit(); TrueTypeFontUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TrueTypeFontUtil.jclinitDone then
            TrueTypeFontUtil.jclinitDone <- true
            TrueTypeFontUtil.jclinitBody()
    static member private jclinitBody() : unit =
        TrueTypeFontUtil.jcell_instance <- (new TrueTypeFontUtil())
        ()
    member this.jfields_TrueTypeFontUtil() : unit =
        this.fontImage <- OpenGLESImage.NULL_OPENGL_IMAGE
        ()
    
    static member getInstance() : TrueTypeFontUtil =
        TrueTypeFontUtil.instance
    
    new () as this =
        { inherit TrueTypeFontUtilBase(1) }
        then
            this.jfields_TrueTypeFontUtil()
    
    override this.getAsTextureSize(textureSize: int) : int =
        raise ((new JRuntimeException()))
    
    override this.getCellSize(cellSize: int) : int =
        raise ((new JRuntimeException()))
    
    abstract getFontBitmap : filename: string * fontSize: int * cellSize: int * basicColor: BasicColor -> Image
    default this.getFontBitmap(filename: string, fontSize: int, cellSize: int, basicColor: BasicColor) : Image =
        raise ((new JRuntimeException()))
    
    abstract saveFontAtlasAsFile : unit -> unit
    default this.saveFontAtlasAsFile() : unit =
        ()
    
    abstract getFontBitmapGL : gl: GL10 * filename: string * cellSize: int * basicColor: BasicColor -> Image
    default this.getFontBitmapGL(gl: GL10, filename: string, cellSize: int, basicColor: BasicColor) : Image =
        raise ((new JRuntimeException()))
    
    abstract getFontWidths : filename: string * fontSize: int -> int[]
    default this.getFontWidths(filename: string, fontSize: int) : int[] =
        raise ((new JRuntimeException()))


