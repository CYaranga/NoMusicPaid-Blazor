function InitAudio(id) {

    new GreenAudioPlayer('#' + id, { stopOthersOnPlay: true });
    // GreenAudioPlayer.init({
    //     selector: '.player-music', // inits Green Audio Player on each audio container that has class "player"
    //     stopOthersOnPlay: true
    // });
}