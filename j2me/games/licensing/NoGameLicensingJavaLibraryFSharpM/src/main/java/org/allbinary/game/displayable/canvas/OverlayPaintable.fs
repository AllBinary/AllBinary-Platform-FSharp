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
type OverlayPaintable =
    inherit InitUpdatePaintable
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OverlayPaintable.jclinitDone then
            OverlayPaintable.jclinitDone <- true
            OverlayPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_OverlayPaintable() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new () as this =
        { inherit InitUpdatePaintable() }
        then
            this.jfields_OverlayPaintable()
    
    override this.update() : unit =
        try
            ()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.UPDATE, e)
            | _ -> reraise ()
    
    override this.paint(graphics: Graphics) : unit =
        ()


