cd Android
./gradlew assembleDebug
cd ..
mkdir ./Release
mkdir ./Release/Android
copy ./Android/app/build/outputs/apk/app-debug.apk ./Release/Android/app-debug.apk
