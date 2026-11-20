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
type BasicColorSetUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : BasicColorSetUtil
    static member instance with get() : BasicColorSetUtil = (BasicColorSetUtil.jclinit(); BasicColorSetUtil.jcell_instance) and set (jvalue: BasicColorSetUtil) = (BasicColorSetUtil.jclinit(); BasicColorSetUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicColorSetUtil.jclinitDone then
            BasicColorSetUtil.jclinitDone <- true
            BasicColorSetUtil.jclinitBody()
    static member private jclinitBody() : unit =
        BasicColorSetUtil.jcell_instance <- (new BasicColorSetUtil())
        ()
    
    static member getInstance() : BasicColorSetUtil =
        BasicColorSetUtil.instance
    
    new () =
        {  }
    
    abstract setBasicColorP : graphics: Graphics * basicColor: BasicColor -> unit
    default this.setBasicColorP(graphics: Graphics, basicColor: BasicColor) : unit =
        graphics.setColor(basicColor.intValue())
    
    abstract setBasicColorP3 : graphics: Graphics * basicColor: BasicColor * value: int -> unit
    default this.setBasicColorP3(graphics: Graphics, basicColor: BasicColor, value: int) : unit =
        graphics.setColor(value)


