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
type SWTBlackPaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable basicSetColorUtil : BasicColorSetUtil
    [<DefaultValue(false)>] val mutable BLACK : BasicColor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SWTBlackPaintable.jclinitDone then
            SWTBlackPaintable.jclinitDone <- true
            SWTBlackPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        { inherit Paintable() }
        then
            this.jfields_SWTBlackPaintable()
    member this.jfields_SWTBlackPaintable() : unit =
        this.basicSetColorUtil <- BasicColorSetUtil.getInstance()
        this.BLACK <- BasicColorFactory.getInstance().BLACK
        ()
    
    override this.paint(graphics: Graphics) : unit =
        this.basicSetColorUtil.setBasicColorP(graphics, this.BLACK)


