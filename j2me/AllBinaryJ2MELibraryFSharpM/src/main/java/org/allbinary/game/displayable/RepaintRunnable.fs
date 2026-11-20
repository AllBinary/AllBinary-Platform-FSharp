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
type RepaintRunnable =
    inherit ARunnable
    [<DefaultValue(false)>] val mutable canvas : Canvas
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RepaintRunnable.jclinitDone then
            RepaintRunnable.jclinitDone <- true
            RepaintRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (canvas: Canvas) as this =
        { inherit ARunnable() }
        then
            this.jctor1(canvas)
    member this.jctor1(canvas: Canvas) : unit =
        this.canvas <- canvas
        ()
    
    override this.run() : unit =
        try
            this.canvas.repaint()
            DisplayInfoSingleton.getInstance().process_()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                let mutable logUtil : LogUtil = LogUtil.getInstance()
                logUtil.put(commonStrings.EXCEPTION, this, commonStrings.RUN, e)
            | _ -> reraise ()


