# Nfc Assist Test

NfcAssist를 이용하여 만든 NFC 리더/라이트 테스트 프로그램입니다.



## 프로젝트에 포함된 장비 정보

테스트 가능한 장비
- ACR12U

카드
- Mifare1k

'DeviceCommand'폴더에 형식에 맞게 장비 정보를 만들어 넣으면 테스트할 수 있습니다.
(참고 : NfcAssist/NfcDeviceCommandAssists/DeviceCommand_JsonModel.cs)

'CardInfo'폴더에 형식에 맞게 카드정보를 만들어 넣으면 프로그램에서 테스트할 수 있습니다.
(참고 : NfcAssist/NfcCardInfo/CardInfoInterface.cs)
