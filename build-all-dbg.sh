cd Android
./gradlew assembleDebug
cd ..
mkdir -p ./Release
mkdir -p ./Release/Android
cp ./Android/app/build/outputs/apk/app-debug.apk ./Release/Android/app-debug.apk

