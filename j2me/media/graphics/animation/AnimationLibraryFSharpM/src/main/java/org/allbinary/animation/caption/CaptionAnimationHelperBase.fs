namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type CaptionAnimationHelperBase =
    inherit Animation
    [<DefaultValue(false)>] static val mutable private jcell_INSTANCE : CaptionAnimationHelperBase
    static member INSTANCE with get() : CaptionAnimationHelperBase = (CaptionAnimationHelperBase.jclinit(); CaptionAnimationHelperBase.jcell_INSTANCE) and set (jvalue: CaptionAnimationHelperBase) = (CaptionAnimationHelperBase.jclinit(); CaptionAnimationHelperBase.jcell_INSTANCE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CaptionAnimationHelperBase.jclinitDone then
            CaptionAnimationHelperBase.jclinitDone <- true
            CaptionAnimationHelperBase.jclinitBody()
    static member private jclinitBody() : unit =
        CaptionAnimationHelperBase.jcell_INSTANCE <- (new CaptionAnimationHelperBase())
        ()
    new () =
        { inherit Animation() }
    
    abstract isShowing : unit -> bool
    default this.isShowing() : bool =
        false
    
    abstract tick : unit -> unit
    default this.tick() : unit =
        ()
    
    abstract update : message: string * basicColor: BasicColor -> unit
    default this.update(message: string, basicColor: BasicColor) : unit =
        ()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        ()


