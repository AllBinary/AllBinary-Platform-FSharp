namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type TrueTypeFontUtilBase =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TrueTypeFontUtilBase.jclinitDone then
            TrueTypeFontUtilBase.jclinitDone <- true
            TrueTypeFontUtilBase.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (scale: int) =
        {  }
    
    abstract getAsTextureSize : textureSize: int -> int
    default this.getAsTextureSize(textureSize: int) : int =
        -1
    
    abstract getCellSize : cellSize: int -> int
    default this.getCellSize(cellSize: int) : int =
        -1


