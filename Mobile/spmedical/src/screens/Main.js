import * as React from 'react'
import { Image, StatusBar, StyleSheet, View } from 'react-native';

import { createDrawerNavigator } from '@react-navigation/drawer';

const Drawer = createDrawerNavigator();

//Importa telas
import Consultas from './Consultas'
import Perfil from './Perfil'


export default function Main() {

    return (
        <View style={styles.main}>
            <StatusBar
                hidden={false}
                backgroundColor={'#0E2D89'}
            />

            <Drawer.Navigator 
            initialRouteName='Consultas'
            drawerStatusBarAnimation='none'
            unmountOnBlur={true}
            headershown={false}
            >
                <Drawer.Screen name='Consultas' component={Consultas}/>
                <Drawer.Screen name='Perfil' component={Perfil}/>
            </Drawer.Navigator>
        </View>
    )
}

const styles = StyleSheet.create({
    main: {
        flex: 1
    }
})