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
type HighScoreCommandsBaseFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable HIGH_SCORE_COMMANDS : Command[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoreCommandsBaseFactory.jclinitDone then
            HighScoreCommandsBaseFactory.jclinitDone <- true
            HighScoreCommandsBaseFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HighScoreCommandsBaseFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new (HIGH_SCORE_COMMANDS: Command[]) as this =
        {  }
        then
            this.jfields_HighScoreCommandsBaseFactory()
            this.jctor1(HIGH_SCORE_COMMANDS)
    member this.jctor1(HIGH_SCORE_COMMANDS: Command[]) : unit =
        this.HIGH_SCORE_COMMANDS <- HIGH_SCORE_COMMANDS
        ()
    
    abstract isHighScoreCommand : command: Command -> bool
    default this.isHighScoreCommand(command: Command) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable index : int = this.HIGH_SCORE_COMMANDS.Length - 1
        while jflow = 0 && (index >= 0) do
            if (JR.same(command, this.HIGH_SCORE_COMMANDS.[index])) then
                jret <- true
                jflow <- 1
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index - 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract getIndex : command: Command -> int
    default this.getIndex(command: Command) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        let mutable index : int = this.HIGH_SCORE_COMMANDS.Length - 1
        while jflow = 0 && (index >= 0) do
            if (JR.same(command, this.HIGH_SCORE_COMMANDS.[index])) then
                jret <- index
                jflow <- 1
            if jflow = 200002 then jflow <- 0
            if jflow = 0 then index <- index - 1
        if jflow = 100002 then jflow <- 0
        if jflow = 0 then
            raise ((new JException("No Such Command")))
        jret


