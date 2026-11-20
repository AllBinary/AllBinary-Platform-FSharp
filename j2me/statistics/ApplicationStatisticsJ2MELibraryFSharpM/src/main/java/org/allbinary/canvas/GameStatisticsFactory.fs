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
type GameStatisticsFactory =
    inherit BaseGameStatistics
    [<DefaultValue(false)>] val mutable stringBuffer : StringMaker
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameStatisticsFactory
    static member instance with get() : GameStatisticsFactory = (GameStatisticsFactory.jclinit(); GameStatisticsFactory.jcell_instance) and set (jvalue: GameStatisticsFactory) = (GameStatisticsFactory.jclinit(); GameStatisticsFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameStatisticsFactory.jclinitDone then
            GameStatisticsFactory.jclinitDone <- true
            GameStatisticsFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameStatisticsFactory.jcell_instance <- (new GameStatisticsFactory())
        ()
    new () as this =
        { inherit BaseGameStatistics() }
        then
            this.jfields_GameStatisticsFactory()
    member this.jfields_GameStatisticsFactory() : unit =
        this.stringBuffer <- (new StringMaker())
        ()
    
    static member getInstance() : GameStatisticsFactory =
        GameStatisticsFactory.instance
    
    override this.add(string_: string) : unit =
        if this.stringBuffer.length() > 12000 then
            ignore (this.stringBuffer.delete(0, this.stringBuffer.length()))
            ignore (this.stringBuffer.append("Old Stats Cleared"))
        ignore (this.stringBuffer.append(string_))
    
    override this.ToString() : string =
        (new StringMaker()).append(base.ToString()).append(this.stringBuffer.ToString()).ToString()


