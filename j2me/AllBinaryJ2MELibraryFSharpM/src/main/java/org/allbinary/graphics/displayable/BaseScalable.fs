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
type BaseScalable =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseScalable.jclinitDone then
            BaseScalable.jclinitDone <- true
            BaseScalable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getRatio : ratio: float32 -> float32
    default this.getRatio(ratio: float32) : float32 =
        1.0f
    
    abstract getLeft : xOffset: int -> int
    default this.getLeft(xOffset: int) : int =
        -1
    
    abstract getTop : yOffset: int -> int
    default this.getTop(yOffset: int) : int =
        -1
    
    abstract scale : ratio: float32 -> unit
    default this.scale(ratio: float32) : unit =
        ()
    interface ScalableListener with
        member this.getRatio(jp0: float32) : float32 = this.getRatio(jp0)
        member this.getLeft(jp0: int) : int = this.getLeft(jp0)
        member this.getTop(jp0: int) : int = this.getTop(jp0)
        member this.scale(jp0: float32) : unit = this.scale(jp0)


