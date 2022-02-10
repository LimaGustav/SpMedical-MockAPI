import React from 'react';
import { FlatList, Image, ImageBackground, StyleSheet, Text, TouchableOpacity, View } from 'react-native';

import api from '../services/api'

import AsyncStorage from '@react-native-async-storage/async-storage';
import { useState, useEffect } from 'react';



export default function Consultas() {
    const [listaConsulta, setListaConsulta] = useState([])

    const buscarConsultas = async () => {
        const token = await AsyncStorage.getItem('userToken');

        if (token != null) {
            const resposta = await api.get('/consultas/minhas', {
                headers: {
                    Authorization: 'Bearer ' + token,
                }
            })

            setListaConsulta(resposta.data)
        }
    }

    useEffect(() => { buscarConsultas() }, [])

    const renderItem = ({ item }) => (
        <View style={styles.main_container}>
            <View style={styles.card}>
                <View style={styles.card_title_container}>
                    <Text style={styles.card_title}>
                        {item.dataConsulta}
                    </Text>
                </View>

                <View style={styles.card_text}>
                    <Text style={styles.bold}>Paciente: <Text>{item.idPacienteNavigation.nomePaciente}</Text></Text>
                    <Text style={styles.bold}>Médico: <Text>{item.idMedicoNavigation.nomeMedico}</Text></Text>
                    <Text style={styles.bold}>Descricao: <Text>{item.descricao}</Text></Text>
                </View>
            </View>
        </View>
    )

    return (
        <ImageBackground
            source={require('../../assets/images/spConsulta.png')}
            style={StyleSheet.absoluteFillObject}
        >
            <View style={styles.wrapper}>
                <Text style={styles.title}>
                    Consultas
                </Text>
            </View>
            <FlatList
                    contentContainerStyle={styles.mainBodyContent}
                    data={listaConsulta}
                    keyExtractor={item => item.idConsulta}
                    renderItem={renderItem}
                />


            {/* <View style={styles.main_container}>
                <Text style={styles.title}>
                    Consultas
                </Text>

                <View style={styles.card}>
                    <View style={styles.card_title_container}>
                        <Text style={styles.card_title}>
                            12/03/2006
                        </Text>
                    </View>

                    <View style={styles.card_text}>
                        <Text style={styles.bold}>Paciente: </Text>
                        <Text style={styles.bold}>Médico: </Text>
                        <Text style={styles.bold}>Descricao: </Text>
                    </View>
                </View>
            </View> */}

        </ImageBackground>
    )


}

const styles = StyleSheet.create({
    main_container: {
        alignItems: 'center',
        justifyContent: 'space-around',
        marginBottom: 40
    },

    container_flat_list: {
        flex: 1
    },

    wrapper: {
        alignItems: 'center',
    },

    mainBodyContent: {
        // flex: 1
    },

    title: {
        fontSize: 48,
        lineHeight: 76,
        color: '#FFFFFF',
        fontWeight: 'bold',
        margin: 15
    },

    card: {
        width: '80%'
    },

    card_title_container: {
        backgroundColor: '#9BD5E5',
        height: 46,
        alignItems: 'center',
        justifyContent: 'center'
    },

    card_title: {
        fontSize: 20,
        fontWeight: 'bold',
        color: 'white'
    },

    bold: {
        fontWeight: 'bold'
    },

    card_text: {
        backgroundColor: '#FFFFFF',
        height: 126,
        borderBottomLeftRadius: 15,
        borderBottomRightRadius: 15,
        justifyContent: 'space-around',
        padding: 14
    },

})