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
type HighScoreUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable highScoresFactoryInterface : HighScoresFactoryInterface
    [<DefaultValue(false)>] val mutable highScoresArray : HighScores[]
    [<DefaultValue(false)>] val mutable highScore : HighScore
    [<DefaultValue(false)>] val mutable abeClientInformation : AbeClientInformationInterface
    [<DefaultValue(false)>] val mutable gameInfo : GameInfo
    [<DefaultValue(false)>] val mutable highScoresHelper : HighScoresHelperBaseInterface
    [<DefaultValue(false)>] val mutable firstTime : bool
    [<DefaultValue(false)>] static val mutable private jcell_SUBMIT_TEXTBOX_COMMAND : Command
    static member SUBMIT_TEXTBOX_COMMAND with get() : Command = (HighScoreUtil.jclinit(); HighScoreUtil.jcell_SUBMIT_TEXTBOX_COMMAND) and set (jvalue: Command) = (HighScoreUtil.jclinit(); HighScoreUtil.jcell_SUBMIT_TEXTBOX_COMMAND <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoreUtil.jclinitDone then
            HighScoreUtil.jclinitDone <- true
            HighScoreUtil.jclinitBody()
    static member private jclinitBody() : unit =
        HighScoreUtil.jcell_SUBMIT_TEXTBOX_COMMAND <- (new Command("Submit", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        ()
    member this.jfields_HighScoreUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.firstTime <- true
        ()
    
    new (highScoresFactoryInterface: HighScoresFactoryInterface, highScoresHelper: HighScoresHelperBaseInterface, abeClientInformation: AbeClientInformationInterface, gameInfo: GameInfo, cmdListener: CommandListener, name: string, highScore: HighScore) as this =
        {  }
        then
            this.jfields_HighScoreUtil()
            this.jctor1(highScoresFactoryInterface, highScoresHelper, abeClientInformation, gameInfo, cmdListener, name, highScore)
    member this.jctor1(highScoresFactoryInterface: HighScoresFactoryInterface, highScoresHelper: HighScoresHelperBaseInterface, abeClientInformation: AbeClientInformationInterface, gameInfo: GameInfo, cmdListener: CommandListener, name: string, highScore: HighScore) : unit =
        this.highScoresFactoryInterface <- highScoresFactoryInterface
        this.highScoresHelper <- highScoresHelper
        this.highScoresArray <- this.highScoresHelper.getHighScoresArray()
        this.highScore <- highScore
        this.abeClientInformation <- abeClientInformation
        this.gameInfo <- gameInfo
        ()
    
    abstract setHighScoresArray : highScoresArray: HighScores[] -> unit
    default this.setHighScoresArray(highScoresArray: HighScores[]) : unit =
        this.highScoresArray <- highScoresArray
        this.firstTime <- false
        this.saveHighScore()
    
    abstract update : name: string -> unit
    default this.update(name: string) : unit =
        HighScoreNamePersistanceSingleton.getInstance().save(this.abeClientInformation, this.gameInfo, name)
        this.highScore.setName(name)
    
    abstract saveHighScore : unit -> unit
    default this.saveHighScore() : unit =
        let mutable jflow = 0
        this.logUtil.putF((new StringMaker()).append(this.commonStrings.START).append(StringUtil.getInstance().toString(this.highScore)).ToString(), this, "saveHighScore")
        let mutable size : int = this.highScoresArray.Length
        if this.firstTime && (size = 0) then
            this.logUtil.putF("Games canvas did not give us any HighScores", this, "saveHighScore")
            this.highScoresFactoryInterface.fetchHighScores(this.gameInfo, this)
            jflow <- 1
        if jflow = 0 then
            let mutable highScores : HighScores = null
            let mutable highScoresAsString : string = null
            let mutable index : int = 0
            while index < size do
                highScores <- this.highScoresArray.[index]
                highScores.addHighScore(this.highScore)
                highScoresAsString <- highScores.ToString()
                this.logUtil.putF((new StringMaker()).append("Added/Adding Score: ").append(highScoresAsString).ToString(), this, "saveHighScore")
                index <- index + 1
            this.highScoresHelper.setHighScoresArray(this.highScoresArray)
    
    abstract submit : myCanvas: MyCanvas -> unit
    default this.submit(myCanvas: MyCanvas) : unit =
        let mutable commandListener : CommandListener = myCanvas.getCustomCommandListener()
        commandListener.commandAction(HighScoreUtil.SUBMIT_TEXTBOX_COMMAND, myCanvas)
    interface HighScoresResultsListener with
        member this.setHighScoresArray(jp0: HighScores[]) : unit = this.setHighScoresArray(jp0)


