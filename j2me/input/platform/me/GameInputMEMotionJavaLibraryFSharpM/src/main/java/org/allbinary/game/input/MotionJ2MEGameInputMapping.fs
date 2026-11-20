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
type MotionJ2MEGameInputMapping =
    inherit J2MEGameInputMapping
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MotionJ2MEGameInputMapping.jclinitDone then
            MotionJ2MEGameInputMapping.jclinitDone <- true
            MotionJ2MEGameInputMapping.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        { inherit J2MEGameInputMapping() }
    
    override this.getDefault() : InputToGameKeyMapping =
        (new MotionJ2MEDefaultGameInputMapping()).getInputMapping()


