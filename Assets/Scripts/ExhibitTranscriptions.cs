using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.CognitiveServices.Speech;
using UnityEngine.Networking;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech.Audio;
using Microsoft.MixedReality.Toolkit.UI;
using System.IO;

public class ExhibitTranscriptions : MonoBehaviour
{
    public string SpeechServiceSubscriptionKey = "";
    public string SpeechServiceRegion = "";

    private SpeechConfig config;
    private AudioConfig audioConfig;
    private string outputPath;

    private AudioClip _audioClip;

    public AudioSource audioSource;

    public string GeneratedFileName = "azureSpeechSynth.wav";

    // Start is called before the first frame update
    public async void TranscribeNeilExhibit()
    {
        outputPath = Path.Combine(Application.dataPath, GeneratedFileName);
        var config = SpeechConfig.FromSubscription(SpeechServiceSubscriptionKey, SpeechServiceRegion);
        config.SpeechSynthesisLanguage = "en-US";
        config.SpeechSynthesisVoiceName = "en-US-JennyNeural";
        config.SetSpeechSynthesisOutputFormat(SpeechSynthesisOutputFormat.Riff24Khz16BitMonoPcm);
        audioConfig = AudioConfig.FromWavFileOutput(outputPath);

        using (var synthesizer = new SpeechSynthesizer(config, audioConfig))
            await synthesizer.SpeakTextAsync("This spacesuit was worn by astronaut Neil Armstrong, Commander of the Apollo 11 mission, which landed the first man on the Moon on July 20, 1969. The lunar spacesuits were designed to provide a life sustaining environment for the astronaut during periods of extra vehicular activity or during unpressurized spacecraft operation. They permitted maximum mobility and were designed to be worn with relative comfort for up to 115 hours in conjunction with the liquid cooling garment. If necessary, they were also capable of being worn for 14 days in an unpressurized mode. The spacesuit has the designation A-7L, and was constructed in the Extra-vehicular or EV configuration.");


        Debug.Log("will save the file to: " + outputPath);

        _audioClip = await GetAudioClip(outputPath, AudioType.WAV);
        audioSource.Stop();
        audioSource.PlayOneShot(_audioClip, 1.0f);
    }

    public async void TranscribeCommandModuleExhibit()
    {
        outputPath = Path.Combine(Application.dataPath, GeneratedFileName);
        var config = SpeechConfig.FromSubscription(SpeechServiceSubscriptionKey, SpeechServiceRegion);
        config.SpeechSynthesisLanguage = "en-US";
        config.SpeechSynthesisVoiceName = "en-US-JennyNeural";
        config.SetSpeechSynthesisOutputFormat(SpeechSynthesisOutputFormat.Riff24Khz16BitMonoPcm);
        audioConfig = AudioConfig.FromWavFileOutput(outputPath);

        using (var synthesizer = new SpeechSynthesizer(config, audioConfig))
            await synthesizer.SpeakTextAsync("The Apollo 11 Command Module, Columbia, was the living quarters for the three-person crew during most of the first crewed lunar landing mission in July 1969. On July 16, 1969, Neil Armstrong, Edwin Buzz Aldrin and Michael Collins were launched from Cape Kennedy atop a Saturn V rocket. This Command Module, number 107, manufactured by North American Rockwell, was one of three parts of the complete Apollo spacecraft. The other two parts were the Service Module and the Lunar Module, nicknamed Eagle. The Service Module contained the main spacecraft propulsion system and consumables while the Lunar Module was the two-person craft used by Armstrong and Aldrin to descend to the Moon's surface on July 20th. The Command Module is the only portion of the spacecraft to return to Earth.");


        Debug.Log("will save the file to: " + outputPath);

        _audioClip = await GetAudioClip(outputPath, AudioType.WAV);
        audioSource.Stop();
        audioSource.PlayOneShot(_audioClip, 1.0f);
    }


    public async Task<AudioClip> GetAudioClip(string filePath, AudioType fileType)
    {

        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(filePath, fileType))
        {
            var result = www.SendWebRequest();

            while (!result.isDone) { await Task.Delay(100); }

            return DownloadHandlerAudioClip.GetContent(www);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        // register the click handler
        //InfoButton.ButtonPressed.AddListener(TranscribeNeilExhibit);


    }
}
